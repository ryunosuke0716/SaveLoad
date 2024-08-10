using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerprefs : MonoBehaviour
{
    public void Start() 
    {
        //SavePrefs();
        LoadPrefs();
    }

    public string test;
    public Text text;
    //public Button btn;
    public InputField ipfd;
    
    /*public void SavePrefs()
    {
        //Debug.Log(ipfd.text);
        //PlayerPrefs.SetString("Name", test);
        PlayerPrefs.SetString("Name", ipfd.text);
        PlayerPrefs.Save();
    }*/

    public void LoadPrefs()
    {
        string name = PlayerPrefs.GetString("Name");
        Debug.Log(name);
    }
}