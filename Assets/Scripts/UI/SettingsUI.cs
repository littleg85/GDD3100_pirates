using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SettingsUI : MonoBehaviour
{
    private Variables var;

    private void Start()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    public void BindMoveForward(string newText)
    {
        //string temp = KeyCode.Parse(newText);
        //var.booty = temp;
    }

}

