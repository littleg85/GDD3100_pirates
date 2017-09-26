using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System;

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        //MAP

        if (gameObject.name == "NE_mo")
        {
            GameObject.Find("TowerMapNE").GetComponent<Image>().enabled = true;
        }

        if (gameObject.name == "NW_mo")
        {
            GameObject.Find("TowerMapNW").GetComponent<Image>().enabled = true;
        }

        if (gameObject.name == "S_mo")
        {
            GameObject.Find("TowerMapS").GetComponent<Image>().enabled = true;
        }

        if (gameObject.name == "SW_mo")
        {
            GameObject.Find("TowerMapSW").GetComponent<Image>().enabled = true;
        }

        if (gameObject.name == "E_mo")
        {
            GameObject.Find("TowerMapE").GetComponent<Image>().enabled = true;
        }

        //TOWERS

        if (gameObject.name == "NE1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "NE2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "NE3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = true;
        }

        if (gameObject.name == "NW1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "NW2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "NW3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = true;
        }

        if (gameObject.name == "S1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "S2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "S3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = true;
        }

        if (gameObject.name == "SW1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "SW2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "SW3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = true;
        }

        if (gameObject.name == "E1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "E2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = true;
        }
        if (gameObject.name == "E3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = true;
        }

        //UPGRADES

        if (gameObject.name == "pHealth1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "pHealth2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "pHealth3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = true;
        }

        if (gameObject.name == "pAttack1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "pAttack2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "pAttack3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = true;
        }

        if (gameObject.name == "aSpeed1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "aSpeed2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "aSpeed3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = true;
        }

        if (gameObject.name == "pSpeed1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "pSpeed2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "pSpeed3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = true;
        }

        if (gameObject.name == "Mob1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "Mob2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = true;
        }
        if (gameObject.name == "Mob3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = true;
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //MAPS

        if (gameObject.name == "NE_mo")
        {
            GameObject.Find("TowerMapNE").GetComponent<Image>().enabled = false;
        }

        if (gameObject.name == "NW_mo")
        {
            GameObject.Find("TowerMapNW").GetComponent<Image>().enabled = false;
        }

        if (gameObject.name == "S_mo")
        {
            GameObject.Find("TowerMapS").GetComponent<Image>().enabled = false;
        }

        if (gameObject.name == "SW_mo")
        {
            GameObject.Find("TowerMapSW").GetComponent<Image>().enabled = false;
        }

        if (gameObject.name == "E_mo")
        {
            GameObject.Find("TowerMapE").GetComponent<Image>().enabled = false;
        }

        //TOWERS

        if (gameObject.name == "NE1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "NE2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "NE3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = false;
        }

        if (gameObject.name == "NW1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "NW2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "NW3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = false;
        }

        if (gameObject.name == "S1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "S2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "S3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = false;
        }

        if (gameObject.name == "SW1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "SW2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "SW3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = false;
        }

        if (gameObject.name == "E1")
        {
            GameObject.Find("Tower1").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "E2")
        {
            GameObject.Find("Tower2").GetComponent<Image>().enabled = false;
        }
        if (gameObject.name == "E3")
        {
            GameObject.Find("Tower3").GetComponent<Image>().enabled = false;
        }

        //UPGRADES

        if (gameObject.name == "pHealth1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "pHealth2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "pHealth3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = false;
        }

        if (gameObject.name == "pAttack1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "pAttack2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "pAttack3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = false;
        }

        if (gameObject.name == "aSpeed1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "aSpeed2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "aSpeed3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = false;
        }

        if (gameObject.name == "pSpeed1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "pSpeed2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "pSpeed3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = false;
        }

        if (gameObject.name == "Mob1")
        {
            GameObject.Find("Cost1000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "Mob2")
        {
            GameObject.Find("Cost2000").GetComponent<Text>().enabled = false;
        }
        if (gameObject.name == "Mob3")
        {
            GameObject.Find("Cost3000").GetComponent<Text>().enabled = false;
        }
    }

}

