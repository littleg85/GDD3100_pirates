using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpgradeText : MonoBehaviour
{
    private Variables var;
    public Text Level;
    public Text Cost;

    private Button button;

    //Towers
    public GameObject highlights;
    public GameObject NE;
    public GameObject E;
    public GameObject S;
    public GameObject SW;
    public GameObject NW;
    private int totalCost;
    private bool inter = true;

    // Use this for initialization
    void Start()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();
        button = gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

        //Booty available
        if (gameObject.name == "bootyAvail")
        {
            gameObject.GetComponent<Text>().text = "Booty:$" + var.booty;
        }

        //Boat Text
        if (gameObject.name == "Health")
        {
            Level.text = "Level " + var.healthLevel;
            Cost.text = "$" + (1000 + var.healthLevel * 1000);
            if (var.healthLevel == 3)
            {
                Cost.gameObject.SetActive(false);
            }

            if ((1000 + var.healthLevel * 1000) > var.booty)
            {
                button.interactable = false;
            }
            else if (var.healthLevel < 3)
            {
                button.interactable = true;
            }
        }

        if (gameObject.name == "Attack")
        {
            Level.text = "Level " + var.attackLevel;
            Cost.text = "$" + (1000 + var.attackLevel * 1000);
            if (var.attackLevel == 3)
            {
                Cost.gameObject.SetActive(false);
            }

            if ((1000 + var.attackLevel * 1000) > var.booty)
            {
                button.interactable = false;
            }
            else if (var.attackLevel < 3)
            {
                if (var.healthLevel >  0)
                {
                    button.interactable = true;
                }
            }
        }

        if (gameObject.name == "Attack Speed")
        {
            Level.text = "Level " + var.aSpeedLevel;
            Cost.text = "$" + (1000 + var.aSpeedLevel * 1000);
            if (var.aSpeedLevel == 3)
            {
                Cost.gameObject.SetActive(false);
            }

            if ((1000 + var.aSpeedLevel * 1000) > var.booty)
            {
                button.interactable = false;
            }
            else if (var.aSpeedLevel < 3)
            {
                button.interactable = true;
            }
        }

        if (gameObject.name == "Speed")
        {
            Level.text = "Level " + var.speedLevel;
            Cost.text = "$" + (1000 + var.speedLevel * 1000);
            if (var.speedLevel == 3)
            {
                Cost.gameObject.SetActive(false);
            }

            if ((1000 + var.speedLevel * 1000) > var.booty)
            {
                button.interactable = false;
            }
            else if (var.speedLevel < 3)
            {
                button.interactable = true;
            }
        }

        if (gameObject.name == "Mobility")
        {
            Level.text = "Level " + var.tSpeedLevel;
            Cost.text = "$" + (1000 + var.tSpeedLevel * 1000);
            if (var.tSpeedLevel == 3)
            {
                Cost.gameObject.SetActive(false);
            }

            if ((1000 + var.tSpeedLevel * 1000) > var.booty)
            {
                button.interactable = false;
            }
            else if (var.tSpeedLevel < 3)
            {
                button.interactable = true;
            }
        }

        //Tower Text
        //Get cost of all towers and add them
        if (gameObject.name == "Upgrade")
        {
            totalCost = NE.GetComponent<Highlight>().cost +
                E.GetComponent<Highlight>().cost +
                S.GetComponent<Highlight>().cost +
                SW.GetComponent<Highlight>().cost +
                NW.GetComponent<Highlight>().cost;

            //Button interactability
            //Check if ANY towers are max level
            if (var.levelArray[NE.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] > 2 ||
             var.levelArray[E.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] > 2 ||
             var.levelArray[S.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] > 2 ||
             var.levelArray[SW.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] > 2 ||
             var.levelArray[NW.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] > 2)
            {
                //Check if tower is selected and is not max level
                if (NE.GetComponent<Highlight>().selected && var.levelArray[NE.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3 ||
                    E.GetComponent<Highlight>().selected && var.levelArray[E.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3 ||
                    S.GetComponent<Highlight>().selected && var.levelArray[S.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3 ||
                    SW.GetComponent<Highlight>().selected && var.levelArray[SW.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3 ||
                    NW.GetComponent<Highlight>().selected && var.levelArray[NW.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3)
                {
                    //Make button interactable if you have enough money
                    if (var.booty >= totalCost)
                    {
                        button.interactable = true;
                        inter = true;
                    }
                }
                else
                {
                    //Make button not interactable
                    button.interactable = false;
                    inter = false;

                }
            }

            //Check if tower selected is not max level and you have enough money
            if (NE.GetComponent<Highlight>().selected && var.levelArray[NE.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3 ||
                    E.GetComponent<Highlight>().selected && var.levelArray[E.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3 ||
                    S.GetComponent<Highlight>().selected && var.levelArray[S.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3 ||
                    SW.GetComponent<Highlight>().selected && var.levelArray[SW.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3 ||
                    NW.GetComponent<Highlight>().selected && var.levelArray[NW.GetComponent<Highlight>().myTower.GetComponent<TowerUpgrade>().index] < 3)
            {
                inter = true;
                if (var.booty >= totalCost)
                {
                    button.interactable = true;
                }
            }
            else
            {
                button.interactable = false;
            }

            //If button is interactable, write costs
            if (inter)
            {
                Cost.text = "$" + totalCost;
            }
            else
            {
                Cost.text = "";
            }
        }


    }
}
