using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingListMulti : MonoBehaviour
{
    public Text ranktext;

    class Info 
    {
        public string name;
        public int age;
    
        public Info(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
    }
   
    public void ClickButton()
    {
        Info[] src = new Info[]{new Info("Taro", 40), 
                      new Info("Jiro", 30),
                      new Info("Saburo", 20)};
        
        //src.Add(Info[]("saka",49));

        var list = new List<Info>();
      
        // listに要素を追加
        list.AddRange(src);
      
        // listをソート
        var c = new Comparison<Info>(Compare);
        list.Sort(c);

        for(int i = 0; i < 3; i++)
        {
            Debug.Log(list[i].name);
        }        
      
        foreach (Info i in list) 
        {
            Debug.Log(i.name +" "+ i.age);
            ranktext.text = i.name;
        }
    }
    
    static int Compare(Info a, Info b) 
    {
        return a.age - b.age;
    }
}