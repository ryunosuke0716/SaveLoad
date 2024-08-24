using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class LoadListOnPlayerprefs_test : MonoBehaviour
{
    [System.Serializable]
    private class Score
    {
        public int score;
    }


    public Text ranktext;
   
    public void ClickButton()
    {   
        var list0 = PlayerPrefs.GetInt("List");
        Debug.Log(list0);
        
        //var list1 = JsonUtility.FromJson<Score>(list0);

        var list = new List<int>();
        //list.AddRange(list1);

        string[] ranknames = {"1st","2nd","3rd","4th","5th","6th","7th","8th","9th","10th","11th"};

        ranktext.text = "";
        int rank = 0;

        foreach (int i in list) {
            ranktext.text += ranknames[rank] + ": " + i +"\r\n";
            rank = rank + 1;
        }
    }  
}