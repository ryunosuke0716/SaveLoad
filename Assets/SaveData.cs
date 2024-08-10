using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
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