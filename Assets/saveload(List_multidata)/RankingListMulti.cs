using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class RankingListMulti : MonoBehaviour
{
    public Text ranktext;
    public Text text0;
    public Text text1;
    public Text text2;

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
   
    public void ClickButton()
    {
        Info[] src = new Info[]{new Info("Taro", 40), 
                      new Info("Jiro", 30),
                      new Info("Saburo", 20),new Info("Sakaguchi", 100)};
        
        //src.Add(Info[]("saka",49));

        var list = new List<Info>();
      
        // listに要素を追加
        list.AddRange(src);
      
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
            //ranktext.text = i.name;
        }
    }
    
    static int Compare(Info a, Info b) 
    {
        return a.score - b.score;
    }
}