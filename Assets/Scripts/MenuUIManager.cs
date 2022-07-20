using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    public Text Highscore;
    public InputField Username;

    private void Start()
    {
        Highscore.text = "Highscore: " + MenuManager.Instance.Highscore + " UserName:" + MenuManager.Instance.Username;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        MenuManager.Instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
    public void UpdateUsername()
    {
        MenuManager.Instance.Username = Username.text;
        Debug.Log("1 "+MenuManager.Instance.Username);
        Debug.Log("2 "+MenuManager.Instance.Username);
    }
}
