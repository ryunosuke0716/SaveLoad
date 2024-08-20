using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    public InputField ipfdname;
    public InputField ipfdscore;

    [System.Serializable]
    private class UserData
    {
        public string name;
        public string score;
    }

    public void ClickButton()
    {
    //データの設定
    UserData player = new UserData();
    player.name = ipfdname.text;
    player.score = ipfdscore.text;
    string jsonstr = JsonUtility.ToJson(player);
    PlayerPrefs.SetString(ipfdname.text, jsonstr);
    PlayerPrefs.Save();

    Debug.Log(jsonstr);
    //Debug.Log(jsonstr.hp);

    var test = PlayerPrefs.GetString(ipfdname.text);
    Debug.Log(test);
    }
}