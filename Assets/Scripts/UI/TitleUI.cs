using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class TitleUI : MonoBehaviour {

    private Variables var;

    // Use this for initialization
    void Start() {

        var = GameObject.Find("Variables").GetComponent<Variables>();

    }

    // Update is called once per frame
    void Update() {

    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Upgrades()
    {
        SceneManager.LoadScene("Upgrades_v2");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Manual()
    {
        SceneManager.LoadScene("Manual");
    }

    public void Story()
    {
        SceneManager.LoadScene("Story");
    }

    public void Quests()
    {
        SceneManager.LoadScene("Quests");
    }

    public void SetBooty(string newText)
    {
        int temp = int.Parse(newText);
        var.booty = temp;
    }
}
