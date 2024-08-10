using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
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
    //データの設定
    UserData player = new UserData();
    player.hp = 100;
    player.attack = 20;
    player.defense = 7;
    string jsonstr = JsonUtility.ToJson(player);
    PlayerPrefs.SetString("Jsontest", jsonstr);
    PlayerPrefs.Save();

    Debug.Log(jsonstr);

    //データの読み出し
    //var  player2 = JsonUtility.FromJson<UserData>(jsonstr);
    }

    public InputField ipfd;
    public InputField ipfd2;

    public void ClickStartButton()
    {
        PlayerPrefs.SetString("Name", ipfd.text);
        PlayerPrefs.SetString("Number", ipfd2.text);
        PlayerPrefs.Save();
        //Debug.Log(ipfd.text);
    }
}