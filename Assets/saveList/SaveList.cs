using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SaveList : MonoBehaviour
{
    public Text names;
    public Text score;

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
        Player player = new Player();
        //データの設定
        player.jsonname = names.text;
        player.jsonscore = score.text;
        
        Info[] src0 = new Info[]{new Info("sakaguchi",1),new Info("sakasaka",10),new Info("sasasa",100),};
        Info[] src = new Info[]{new Info(names.text,int.Parse(score.text))};
        Debug.Log(names.text +" "+ int.Parse(score.text));

        var list = new List<Info>();
      
        // listに要素を追加
        list.AddRange(src0);
        list.AddRange(src);
        Debug.Log(src);
        
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
    }  
}