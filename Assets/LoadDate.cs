using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadDate : MonoBehaviour
{
    public Text text;

    public void ClickStartButton()
    {
        string name = PlayerPrefs.GetString("Name");
        string number = PlayerPrefs.GetString("Number");
        Debug.Log("名前 " + name + " 点数　" + number);

        text.text = "名前 " + name + " 点数　" + number;
    }
}