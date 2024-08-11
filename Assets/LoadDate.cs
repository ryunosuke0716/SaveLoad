using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadDate : MonoBehaviour
{
    [System.Serializable]
    private class UserData
    {
        public int hp;
        public int attack;
        public int defense;
    }
    private void Start()
    {
    //データの読み出し
        var jsonstr = PlayerPrefs.GetString("Jsontest");
        Debug.Log(jsonstr);
        var  player = JsonUtility.FromJson<UserData>(jsonstr);
        Debug.Log(player.hp +" "+ player.attack + " " + player.defense);
    }

    public Text text;

    public void ClickStartButton()
    {
        string name = PlayerPrefs.GetString("Name");
        string number = PlayerPrefs.GetString("Number");
        Debug.Log("名前 " + name + " 点数　" + number);

        text.text = "名前 " + name + " 点数　" + number;
    }
}