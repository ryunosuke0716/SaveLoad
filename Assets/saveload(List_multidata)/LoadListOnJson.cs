using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class LoadListOnJson : MonoBehaviour
{
    public Text ranktext;
    public Text text0;
    public Text text1;
    public Text text2;

    [System.Serializable]
    private class Player
    {
        public string jsonname;
        public string jsonscore;
    }

    class Info 
    {
        public string name;
        public int score;
    
        public Info(string name, int score) 
        {
            this.name = name;
            this.score = score;
        }
    }

    static int Compare(Info a, Info b) 
    {
        return a.score - b.score;
    }
   
    public void ClickButton()
    {
        var player = PlayerPrefs.GetString("List");
        Debug.Log(player);
        var jsonstr = JsonUtility.FromJson<Player>(player);

        Debug.Log(jsonstr);

        var list = new List<Info>();
        //list.AddRange(jsonstr);
        

        // listをソート
        var c = new Comparison<Info>(Compare);
        list.Sort(c);　//(昇順)
        list.Reverse();　//(降順に変換)

        for(int i = 0; i < 3; i++)
        {
            //Debug.Log(list[i].name);
            //("text"+i).text = i + "位: " + list[i].name;
            if(i==0){
                text0.text = "1st: " + list[i].name + " score " + list[i].score;
            }
            else if(i==1){
                text1.text = "2nd: " + list[i].name + " score " + list[i].score;
            }
            else if(i==2){
                text2.text = "3rd: " + list[i].name + " score " + list[i].score;
            }
        }        
      
        foreach (Info i in list) 
        {
            Debug.Log(i.name +" "+ i.score);
        }
    }
}