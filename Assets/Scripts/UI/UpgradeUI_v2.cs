﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class UpgradeUI_v2 : MonoBehaviour
{
    private Variables var;

    //Buttons
    public GameObject Play;
    public GameObject Menu;
    public GameObject towerButton;
    public GameObject boatButton;
    public GameObject returnBoat;
    public GameObject returnTower;
    public GameObject boatButtons;

    private Text cost;
    private Text bootyAvail;

    public GameObject highlight;
    public GameObject upgrade;

    public Animator anim;

    private void Awake()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();
        //bootyAvail = GameObject.Find("BootyAvail").GetComponent<Text>();

        //Show cursor if no controller
        if (GameObject.Find("Gamepad Controller").GetComponent<GamepadController>().xbox == 1)
        {

        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void Start()
    {
        //bootyAvail.enabled = false;
    }

    private void Update()
    {
        //Store what is clicked on in the event system
        if (var.healthLevel >= 3)
        {
            boatButtons.transform.GetChild(0).gameObject.GetComponent<Button>().interactable = false;
        }
        if (var.attackLevel >= 3)
        {
            boatButtons.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = false;
        }
        if (var.aSpeedLevel >= 3)
        {
            boatButtons.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = false;
        }
        if (var.speedLevel >= 3)
        {
            boatButtons.transform.GetChild(3).gameObject.GetComponent<Button>().interactable = false;
        }
        if (var.tSpeedLevel >= 3)
        {
            boatButtons.transform.GetChild(4).gameObject.GetComponent<Button>().interactable = false;
        }

        if (EventSystem.current.currentSelectedGameObject == null)
        {
            //EventSystem.current.SetSelectedGameObject(GameObject.Find("Return Button Boat"));
        }
        //Don't let you get cannons at heal level 0
        //if (var.healthLevel < 1 && var.attackLevel == 1)
        //{
        //    boatButtons.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = false;
        //}
        //else if (var.attackLevel < 3)
        //{
        //    boatButtons.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
        //}
    }

    public void OnStartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void TowerSelected()
    {
        Play.SetActive(false);
        Menu.SetActive(false);
        towerButton.SetActive(false);
        boatButton.SetActive(false);
        anim.Play("Path_Towers");
    }

    public void BoatSelected()
    {
        Play.SetActive(false);
        Menu.SetActive(false);
        towerButton.SetActive(false);
        boatButton.SetActive(false);
        anim.Play("Path_Boat");
    }

    public void Return()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Path_Boat_Default"))
        {
            anim.Play("Path_Boat_Return");
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Path_Towers_Default"))
        {
            anim.Play("Path_Towers_Return");
        }
        returnTower.SetActive(false);
        returnBoat.SetActive(false);
        highlight.SetActive(false);
        upgrade.SetActive(false);
        boatButtons.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    public void Health()
    {
        if (var.healthLevel == 0 && var.booty >= 1000)
        {
            var.booty -= 1000;
            var.healthLevel++;
        }
        else if (var.healthLevel == 1 && var.booty >= 2000)
        {
            var.booty -= 2000;
            var.healthLevel++;
        }
        else if (var.healthLevel == 2 && var.booty >= 3000)
        {
            var.booty -= 3000;
            var.healthLevel++;
        }
    }

    public void Attack()
    {
        if (var.attackLevel == 0 && var.booty >= 1000)
        {
            var.booty -= 1000;
            var.attackLevel++;
        }
        else if (var.attackLevel == 1 && var.booty >= 2000 && var.healthLevel > 0)
        {
            var.booty -= 2000;
            var.attackLevel++;
        }
        else if (var.attackLevel == 2 && var.booty >= 3000)
        {
            var.booty -= 3000;
            var.attackLevel++;
        }
    }

    public void AttackSpeed()
    {
        if (var.aSpeedLevel == 0 && var.booty >= 1000)
        {
            var.booty -= 1000;
            var.aSpeedLevel++;
        }
        else if (var.aSpeedLevel == 1 && var.booty >= 2000)
        {
            var.booty -= 2000;
            var.aSpeedLevel++;
        }
        else if (var.aSpeedLevel == 2 && var.booty >= 3000)
        {
            var.booty -= 3000;
            var.aSpeedLevel++;
        }
    }

    public void Speed()
    {
        if (var.speedLevel == 0 && var.booty >= 1000)
        {
            var.booty -= 1000;
            var.speedLevel++;
        }
        else if (var.speedLevel == 1 && var.booty >= 2000)
        {
            var.booty -= 2000;
            var.speedLevel++;
        }
        else if (var.speedLevel == 2 && var.booty >= 3000)
        {
            var.booty -= 3000;
            var.speedLevel++;
        }
    }

    public void Mobility()
    {
        if (var.tSpeedLevel == 0 && var.booty >= 1000)
        {
            var.booty -= 1000;
            var.tSpeedLevel++;
        }
        else if (var.tSpeedLevel == 1 && var.booty >= 2000)
        {
            var.booty -= 2000;
            var.tSpeedLevel++;
        }
        else if (var.tSpeedLevel == 2 && var.booty >= 3000)
        {
            var.booty -= 3000;
            var.tSpeedLevel++;
        }
    }
}


