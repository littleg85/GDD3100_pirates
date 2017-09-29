using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class UpgradeUI : MonoBehaviour
{
    private Variables var;
    public GameObject boatFrame;
    public GameObject towerFrame;
    private GameObject current;
    private Text cost;
    private Text bootyAvail;

    private void Awake()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();
        cost = GameObject.Find("Cost").GetComponent<Text>();
        bootyAvail = GameObject.Find("BootyAvail").GetComponent<Text>();

        //Show cursor
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void Start()
    {
        cost.enabled = false;
        bootyAvail.enabled = false;

        //Keep upgrade buttons correct
        if (boatFrame.activeSelf == true)
        {
            //Health column
            if (var.healthLevel == 1)
            {
                GameObject.Find("pHealth1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pHealth1").GetComponent<Button>().interactable = false;
                GameObject.Find("pHealth2").GetComponent<Button>().interactable = true;
            }
            if (var.healthLevel == 2)
            {
                GameObject.Find("pHealth1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pHealth2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pHealth1").GetComponent<Button>().interactable = false;
                GameObject.Find("pHealth2").GetComponent<Button>().interactable = false;
                GameObject.Find("pHealth3").GetComponent<Button>().interactable = true;
            }
            if (var.healthLevel == 3)
            {
                GameObject.Find("pHealth1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pHealth2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pHealth3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pHealth1").GetComponent<Button>().interactable = false;
                GameObject.Find("pHealth2").GetComponent<Button>().interactable = false;
                GameObject.Find("pHealth3").GetComponent<Button>().interactable = false;
            }

            //Attack column
            if (var.attackLevel == 1)
            {
                GameObject.Find("pAttack1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack1").GetComponent<Button>().interactable = false;
                GameObject.Find("pAttack2").GetComponent<Button>().interactable = true;
            }
            if (var.attackLevel == 2)
            {
                GameObject.Find("pAttack1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack1").GetComponent<Button>().interactable = false;
                GameObject.Find("pAttack2").GetComponent<Button>().interactable = false;
                GameObject.Find("pAttack3").GetComponent<Button>().interactable = true;
            }
            if (var.attackLevel == 3)
            {
                GameObject.Find("pAttack1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack1").GetComponent<Button>().interactable = false;
                GameObject.Find("pAttack2").GetComponent<Button>().interactable = false;
                GameObject.Find("pAttack3").GetComponent<Button>().interactable = false;
            }

            //Attack Speed column
            if (var.aSpeedLevel == 1)
            {
                GameObject.Find("aSpeed1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed1").GetComponent<Button>().interactable = false;
                GameObject.Find("aSpeed2").GetComponent<Button>().interactable = true;
            }
            if (var.aSpeedLevel == 2)
            {
                GameObject.Find("aSpeed1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed1").GetComponent<Button>().interactable = false;
                GameObject.Find("aSpeed2").GetComponent<Button>().interactable = false;
                GameObject.Find("aSpeed3").GetComponent<Button>().interactable = true;
            }
            if (var.aSpeedLevel == 3)
            {
                GameObject.Find("aSpeed1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed1").GetComponent<Button>().interactable = false;
                GameObject.Find("aSpeed2").GetComponent<Button>().interactable = false;
                GameObject.Find("aSpeed3").GetComponent<Button>().interactable = false;
            }

            //Speed column
            if (var.speedLevel == 1)
            {
                GameObject.Find("pSpeed1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed1").GetComponent<Button>().interactable = false;
                GameObject.Find("pSpeed2").GetComponent<Button>().interactable = true;
            }
            if (var.speedLevel == 2)
            {
                GameObject.Find("pSpeed1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed1").GetComponent<Button>().interactable = false;
                GameObject.Find("pSpeed2").GetComponent<Button>().interactable = false;
                GameObject.Find("pSpeed3").GetComponent<Button>().interactable = true;
            }
            if (var.speedLevel == 3)
            {
                GameObject.Find("pSpeed1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed1").GetComponent<Button>().interactable = false;
                GameObject.Find("pSpeed2").GetComponent<Button>().interactable = false;
                GameObject.Find("pSpeed3").GetComponent<Button>().interactable = false;
            }

            //Mobility column
            if (var.tSpeedLevel == 1)
            {
                GameObject.Find("Mob1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob1").GetComponent<Button>().interactable = false;
                GameObject.Find("Mob2").GetComponent<Button>().interactable = true;
            }
            if (var.tSpeedLevel == 2)
            {
                GameObject.Find("Mob1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob1").GetComponent<Button>().interactable = false;
                GameObject.Find("Mob2").GetComponent<Button>().interactable = false;
                GameObject.Find("Mob3").GetComponent<Button>().interactable = true;
            }
            if (var.tSpeedLevel == 3)
            {
                GameObject.Find("Mob1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob1").GetComponent<Button>().interactable = false;
                GameObject.Find("Mob2").GetComponent<Button>().interactable = false;
                GameObject.Find("Mob3").GetComponent<Button>().interactable = false;
            }

            boatFrame.SetActive(false);
        }

        //Towers
        if (towerFrame.activeSelf == true)
        {
            //NE
            if (var.NElevel == 1)
            {
                GameObject.Find("NE1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE1").GetComponent<Button>().interactable = false;
                GameObject.Find("NE2").GetComponent<Button>().interactable = true;
            }
            if (var.NElevel == 2)
            {
                GameObject.Find("NE1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE1").GetComponent<Button>().interactable = false;
                GameObject.Find("NE2").GetComponent<Button>().interactable = false;
                GameObject.Find("NE3").GetComponent<Button>().interactable = true;
            }
            if (var.NElevel == 3)
            {
                GameObject.Find("NE1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE1").GetComponent<Button>().interactable = false;
                GameObject.Find("NE2").GetComponent<Button>().interactable = false;
                GameObject.Find("NE3").GetComponent<Button>().interactable = false;
            }

            //SW
            if (var.SWlevel == 1)
            {
                GameObject.Find("SW1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW1").GetComponent<Button>().interactable = false;
                GameObject.Find("SW2").GetComponent<Button>().interactable = true;
            }
            if (var.SWlevel == 2)
            {
                GameObject.Find("SW1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW1").GetComponent<Button>().interactable = false;
                GameObject.Find("SW2").GetComponent<Button>().interactable = false;
                GameObject.Find("SW3").GetComponent<Button>().interactable = true;
            }
            if (var.SWlevel == 3)
            {
                GameObject.Find("SW1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW1").GetComponent<Button>().interactable = false;
                GameObject.Find("SW2").GetComponent<Button>().interactable = false;
                GameObject.Find("SW3").GetComponent<Button>().interactable = false;
            }

            //S
            if (var.Slevel == 1)
            {
                GameObject.Find("S1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S1").GetComponent<Button>().interactable = false;
                GameObject.Find("S2").GetComponent<Button>().interactable = true;
            }
            if (var.Slevel == 2)
            {
                GameObject.Find("S1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S1").GetComponent<Button>().interactable = false;
                GameObject.Find("S2").GetComponent<Button>().interactable = false;
                GameObject.Find("S3").GetComponent<Button>().interactable = true;
            }
            if (var.Slevel == 3)
            {
                GameObject.Find("S1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S1").GetComponent<Button>().interactable = false;
                GameObject.Find("S2").GetComponent<Button>().interactable = false;
                GameObject.Find("S3").GetComponent<Button>().interactable = false;
            }

            //NW
            if (var.NWlevel == 1)
            {
                GameObject.Find("NW1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW1").GetComponent<Button>().interactable = false;
                GameObject.Find("NW2").GetComponent<Button>().interactable = true;
            }
            if (var.NWlevel == 2)
            {
                GameObject.Find("NW1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW1").GetComponent<Button>().interactable = false;
                GameObject.Find("NW2").GetComponent<Button>().interactable = false;
                GameObject.Find("NW3").GetComponent<Button>().interactable = true;
            }
            if (var.NWlevel == 3)
            {
                GameObject.Find("NW1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW1").GetComponent<Button>().interactable = false;
                GameObject.Find("NW2").GetComponent<Button>().interactable = false;
                GameObject.Find("NW3").GetComponent<Button>().interactable = false;
            }

            //E
            if (var.Elevel == 1)
            {
                GameObject.Find("E1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E1").GetComponent<Button>().interactable = false;
                GameObject.Find("E2").GetComponent<Button>().interactable = true;
            }
            if (var.Elevel == 2)
            {
                GameObject.Find("E1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E1").GetComponent<Button>().interactable = false;
                GameObject.Find("E2").GetComponent<Button>().interactable = false;
                GameObject.Find("E3").GetComponent<Button>().interactable = true;
            }
            if (var.Elevel == 3)
            {
                GameObject.Find("E1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E1").GetComponent<Button>().interactable = false;
                GameObject.Find("E2").GetComponent<Button>().interactable = false;
                GameObject.Find("E3").GetComponent<Button>().interactable = false;
            }
            towerFrame.SetActive(false);
        }
    }

    private void Update()
    {
        //Store what is clicked on in the event system
        current = EventSystem.current.currentSelectedGameObject;
    }

    public void OnStartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void BoatUpgrades()
    {
        {
            if (current.name == "pHealth1")
            {
                if (var.booty >= 1000)
                {
                    var.healthLevel = 1;
                    var.booty -= 1000;
                    GameObject.Find("pHealth1").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pHealth1").GetComponent<Button>().interactable = false;
                    GameObject.Find("pHealth2").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "pHealth2")
            {
                if (var.booty >= 2000)
                {
                    var.healthLevel = 2;
                    var.booty -= 2000;
                    GameObject.Find("pHealth2").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pHealth2").GetComponent<Button>().interactable = false;
                    GameObject.Find("pHealth3").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "pHealth3")
            {
                if (var.booty >= 3000)
                {
                    var.healthLevel = 3;
                    var.booty -= 3000;
                    GameObject.Find("pHealth3").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pHealth3").GetComponent<Button>().interactable = false;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "pAttack1")
            {
                if (var.booty >= 1000)
                {
                    var.attackLevel = 1;
                    var.booty -= 1000;
                    GameObject.Find("pAttack1").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pAttack1").GetComponent<Button>().interactable = false;
                    GameObject.Find("pAttack2").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "pAttack2")
            {
                if (var.booty >= 2000)
                {
                    var.attackLevel = 2;
                    var.booty -= 2000;
                    GameObject.Find("pAttack2").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pAttack2").GetComponent<Button>().interactable = false;
                    GameObject.Find("pAttack3").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "pAttack3")
            {
                if (var.booty >= 3000)
                {
                    var.attackLevel = 3;
                    var.booty -= 3000;
                    GameObject.Find("pAttack3").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pAttack3").GetComponent<Button>().interactable = false;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "aSpeed1")
            {
                if (var.booty >= 1000)
                {
                    var.aSpeedLevel = 1;
                    var.booty -= 1000;
                    GameObject.Find("aSpeed1").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("aSpeed1").GetComponent<Button>().interactable = false;
                    GameObject.Find("aSpeed2").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "aSpeed2")
            {
                if (var.booty >= 2000)
                {
                    var.aSpeedLevel = 2;
                    var.booty -= 2000;
                    GameObject.Find("aSpeed2").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("aSpeed2").GetComponent<Button>().interactable = false;
                    GameObject.Find("aSpeed3").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "aSpeed3")
            {
                if (var.booty >= 3000)
                {
                    var.aSpeedLevel = 3;
                    var.booty -= 3000;
                    GameObject.Find("aSpeed3").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("aSpeed3").GetComponent<Button>().interactable = false;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "pSpeed1")
            {
                if (var.booty >= 1000)
                {
                    var.speedLevel = 1;
                    var.booty -= 1000;
                    GameObject.Find("pSpeed1").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pSpeed1").GetComponent<Button>().interactable = false;
                    GameObject.Find("pSpeed2").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "pSpeed2")
            {
                if (var.booty >= 2000)
                {
                    var.speedLevel = 2;
                    var.booty -= 2000;
                    GameObject.Find("pSpeed2").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pSpeed2").GetComponent<Button>().interactable = false;
                    GameObject.Find("pSpeed3").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "pSpeed3")
            {
                if (var.booty >= 3000)
                {
                    var.speedLevel = 3;
                    var.booty -= 3000;
                    GameObject.Find("pSpeed3").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("pSpeed3").GetComponent<Button>().interactable = false;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "Mob1")
            {
                if (var.booty >= 1000)
                {
                    var.tSpeedLevel = 1;
                    var.booty -= 1000;
                    GameObject.Find("Mob1").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("Mob1").GetComponent<Button>().interactable = false;
                    GameObject.Find("Mob2").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }

            }

            if (current.name == "Mob2")
            {
                if (var.booty >= 2000)
                {
                    var.tSpeedLevel = 2;
                    var.booty -= 2000;
                    GameObject.Find("Mob2").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("Mob2").GetComponent<Button>().interactable = false;
                    GameObject.Find("Mob3").GetComponent<Button>().interactable = true;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }

            if (current.name == "Mob3")
            {
                if (var.booty >= 3000)
                {
                    var.tSpeedLevel = 3;
                    var.booty -= 3000;
                    GameObject.Find("Mob3").GetComponent<Button>().image.color = Color.green;
                    GameObject.Find("Mob3").GetComponent<Button>().interactable = false;
                }
                else
                {
                    Debug.Log("Not enough booty");
                }
            }
        }
    }

    public void TowerDropDown()
    {
        towerFrame.SetActive(true);
        cost.enabled = true;
        bootyAvail.enabled = true;
    }

    public void TowerGoBack()
    {
        towerFrame.SetActive(false);
        cost.enabled = false;
        bootyAvail.enabled = false;
    }

    public void BoatDropDown()
    {
        boatFrame.SetActive(true);
        cost.enabled = true;
        bootyAvail.enabled = true;
    }

    public void BoatGoBack()
    {
        boatFrame.SetActive(false);
        cost.enabled = false;
        bootyAvail.enabled = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    //Towers
    public void SetTower()
    {
        if (current.name == "NE1")
        {
            if (var.booty >= 3000)
            {
                var.NElevel = 1;
                var.booty -= 3000;
                GameObject.Find("NE1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE1").GetComponent<Button>().interactable = false;
                GameObject.Find("NE2").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "NE2")
        {
            if (var.booty >= 5000)
            {
                var.NElevel = 2;
                var.booty -= 5000;
                GameObject.Find("NE2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE2").GetComponent<Button>().interactable = false;
                GameObject.Find("NE3").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "NE3")
        {
            if (var.booty >= 7000)
            {
                var.NElevel = 3;
                var.booty -= 7000;
                GameObject.Find("NE3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NE3").GetComponent<Button>().interactable = false;
            }
        }

        if (current.name == "NW1")
        {
            if (var.booty >= 3000)
            {
                var.NWlevel = 1;
                var.booty -= 3000;
                GameObject.Find("NW1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW1").GetComponent<Button>().interactable = false;
                GameObject.Find("NW2").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "NW2")
        {
            if (var.booty >= 5000)
            {
                var.NWlevel = 2;
                var.booty -= 5000;
                GameObject.Find("NW2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW2").GetComponent<Button>().interactable = false;
                GameObject.Find("NW3").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "NW3")
        {
            if (var.booty >= 7000)
            {
                var.NWlevel = 3;
                var.booty -= 7000;
                GameObject.Find("NW3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("NW3").GetComponent<Button>().interactable = false;
            }
        }

        if (current.name == "S1")
        {
            if (var.booty >= 3000)
            {
                var.Slevel = 1;
                var.booty -= 3000;
                GameObject.Find("S1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S1").GetComponent<Button>().interactable = false;
                GameObject.Find("S2").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "S2")
        {
            if (var.booty >= 5000)
            {
                var.Slevel = 2;
                var.booty -= 5000;
                GameObject.Find("S2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S2").GetComponent<Button>().interactable = false;
                GameObject.Find("S3").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "S3")
        {
            if (var.booty >= 7000)
            {
                var.Slevel = 3;
                var.booty -= 7000;
                GameObject.Find("S3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("S3").GetComponent<Button>().interactable = false;
            }
        }

        if (current.name == "SW1")
        {
            if (var.booty >= 3000)
            {
                var.booty -= 3000;
                var.SWlevel = 1;
                GameObject.Find("SW1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW1").GetComponent<Button>().interactable = false;
                GameObject.Find("SW2").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "SW2")
        {
            if (var.booty >= 5000)
            {
                var.booty -= 5000;
                var.SWlevel = 2;
                GameObject.Find("SW2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW2").GetComponent<Button>().interactable = false;
                GameObject.Find("SW3").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "SW3")
        {
            if (var.booty >= 7000)
            {
                var.booty -= 7000;
                var.SWlevel = 3;
                GameObject.Find("SW3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("SW3").GetComponent<Button>().interactable = false;
            }
        }

        if (current.name == "E1")
        {
            if (var.booty >= 3000)
            {
                var.booty -= 3000;
                var.Elevel = 1;
                GameObject.Find("E1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E1").GetComponent<Button>().interactable = false;
                GameObject.Find("E2").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "E2")
        {
            if (var.booty >= 5000)
            {
                var.booty -= 5000;
                var.Elevel = 2;
                GameObject.Find("E2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E2").GetComponent<Button>().interactable = false;
                GameObject.Find("E3").GetComponent<Button>().interactable = true;
            }
        }

        if (current.name == "E3")
        {
            if (var.booty >= 7000)
            {
                var.booty -= 7000;
                var.Elevel = 3;
                GameObject.Find("E3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("E3").GetComponent<Button>().interactable = false;
            }
        }
    }
}

