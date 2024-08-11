using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadByClick : MonoBehaviour
{
    [System.Serializable]
    private class Player
    {
        public string name;
        public string rank;
        public string time;
    }

    public InputField iptname;

    public void ClickStartButton()
    {
        var player = PlayerPrefs.GetString(iptname.text);
        Debug.Log(player);
        var jsonstr = JsonUtility.FromJson<Player>(player);
        Debug.Log(jsonstr.name +" "+ jsonstr.rank +" "+ jsonstr.time);
    }
}