using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SaveListOnPlayerprefstest : MonoBehaviour
{
    [System.Serializable]
    private class Score
    {
        public int score;
    }

    public Text names;
    public Text score;

    public void ClickButton()
    {
        var list = new List<int>()
        {
            10,20,30,40,50,60,70,80,90,100
        };

        // listに要素を追加
        list.Add(1000);
        Debug.Log(list);
        Debug.Log(list[3]);

        list.Reverse();
        Debug.Log(list[3]);
        
        string jsonstr = JsonUtility.ToJson(list);
        Debug.Log(jsonstr);
        
        PlayerPrefs.SetString("List", jsonstr);
        PlayerPrefs.Save();
    }        
}