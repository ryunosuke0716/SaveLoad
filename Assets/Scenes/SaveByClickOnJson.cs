using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveByClick : MonoBehaviour
{
    [System.Serializable]
    private class Player
    {
        public string name;
        public string rank;
        public string time;
    }

    public InputField iptname;
    public InputField iptrank;
    public InputField ipttime;

    public void ClickStartButton()
    {
        Player player = new Player();
        Debug.Log(player);
        //データの設定
        player.name = iptname.text;
        player.rank = iptrank.text;
        player.time = ipttime.text;
        string jsonstr = JsonUtility.ToJson(player);
        PlayerPrefs.SetString(iptname.text, jsonstr);
        PlayerPrefs.Save();

        Debug.Log(jsonstr);
        //Debug.Log(ipfd.text);
    }
}