using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadByClick : MonoBehaviour
{
    public Text ranktext;

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
        if(iptname.text != "")
        {
            var player = PlayerPrefs.GetString(iptname.text);
            Debug.Log(player);
            var jsonstr = JsonUtility.FromJson<Player>(player);
            Debug.Log("name: " + jsonstr.name +"rank: "+ jsonstr.rank +"time: "+ jsonstr.time);

            ranktext.text = "name: " + jsonstr.name +" rank: "+ jsonstr.rank +" time: "+ jsonstr.time;
        }
        else
        {
            Debug.Log("データ無し");
        }
    }
}