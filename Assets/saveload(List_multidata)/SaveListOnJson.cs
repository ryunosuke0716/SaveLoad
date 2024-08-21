using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SaveListOnJson : MonoBehaviour
{
    public Text names;
    public Text score;

    [System.Serializable]
    private class Player
    {
        public string jsonname;
        public string jsonscore;
    }

    class Info 
    {
        public string name1;
        public int score1;
    
        public Info(string name1, int score1) 
        {
            this.name1 = name1;
            this.score1 = score1;
        }
    }
   
    public void ClickButton()
    {
        Player player = new Player();
        //データの設定
        player.jsonname = names.text;
        player.jsonscore = score.text;
        
        Info[] src = new Info[]{new Info(names.text,int.Parse(score.text))};
        Debug.Log(names.text +" "+ int.Parse(score.text));

        var list = new List<Info>();
      
        // listに要素を追加
        list.AddRange(src);
        Debug.Log(src);
        string jsonstr = JsonUtility.ToJson(list);
        Debug.Log(jsonstr);
        PlayerPrefs.SetString("List", jsonstr);
        PlayerPrefs.Save();
    }        
}