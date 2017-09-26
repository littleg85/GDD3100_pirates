using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpgradeText : MonoBehaviour
{

    private Variables var;
    private GameObject bootyAvail;
    public GameObject towerFrame;
    public GameObject boatFrame;
    //private UpgradeUI menuUI;

    // Use this for initialization
    void Start()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();
        bootyAvail = GameObject.Find("BootyAvail");
        //menuUI = GameObject.Find("MenuUI").GetComponent<UpgradeUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (towerFrame.activeSelf == true || boatFrame.activeSelf == true)
        {
            bootyAvail.GetComponent<Text>().text = "Booty: " + var.booty;
        }


        ////Health 
        //if (gameObject.transform.name == "Health")
        //{
        //    if (menuUI.healthClicked)
        //    {
        //        if (var.healthLevel == 0)
        //        {
        //            gameObject.GetComponent<Text>().text = "Health: 20";
        //        }

        //        if (var.healthLevel == 1)
        //        {
        //            gameObject.GetComponent<Text>().text = "Health: 50";
        //        }

        //        if (var.healthLevel == 2)
        //        {
        //            gameObject.GetComponent<Text>().text = "Health: 100";
        //        }
        //    }
        //}

        ////Attack
        //if (gameObject.transform.name == "Attack")
        //{
        //    if (menuUI.attackClicked)
        //    {
        //        if (var.attackLevel == 0)
        //        {
        //            gameObject.GetComponent<Text>().text = "Attack: Rock";
        //        }

        //        if (var.attackLevel == 1)
        //        {
        //            gameObject.GetComponent<Text>().text = "Attack: Guns";
        //        }

        //        if (var.attackLevel == 2)
        //        {
        //            gameObject.GetComponent<Text>().text = "Attack: Cannons/Guns";
        //        }
        //    }
        //}

        ////Attack Speed
        //if (gameObject.transform.name == "Attack Speed")
        //{
        //    if (menuUI.aSpeedClicked)
        //    {
        //        if (var.fireRate == 2f)
        //        {
        //            gameObject.GetComponent<Text>().text = "Reload Time: 2s";
        //        }

        //        if (var.fireRate == 1f)
        //        {
        //            gameObject.GetComponent<Text>().text = "Reload Time: 1s";
        //        }

        //        if (var.fireRate == 0.5f)
        //        {
        //            gameObject.GetComponent<Text>().text = "Reload Time: 0.5s";
        //        }
        //    }
        //}

        ////Player Speed
        //if (gameObject.transform.name == "Speed")
        //{
        //    if (menuUI.pSpeedClicked)
        //    {
        //        if (var.speed == 40000)
        //        {
        //            gameObject.GetComponent<Text>().text = "Speed: 40,000 N";
        //        }

        //        if (var.speed == 60000)
        //        {
        //            gameObject.GetComponent<Text>().text = "Speed: 60,000 N";
        //        }

        //        if (var.speed == 80000)
        //        {
        //            gameObject.GetComponent<Text>().text = "Speed: 80,000 N";
        //        }
        //    }
        //}

        ////Mobility
        //if (gameObject.transform.name == "Mob")
        //{
        //    if (menuUI.mobClicked)
        //    {
        //        if (var.turnSpeed == 50)
        //        {
        //            gameObject.GetComponent<Text>().text = "Mobilty: 50%";
        //        }

        //        if (var.turnSpeed == 75)
        //        {
        //            gameObject.GetComponent<Text>().text = "Mobilty: 75%";
        //        }

        //        if (var.turnSpeed == 100)
        //        {
        //            gameObject.GetComponent<Text>().text = "Mobilty: 100%";
        //        }
        //    }
        //}
    }
}
