using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System;

public class QuestsUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Image scroll;
    private Animator anim;
    private Variables var;
    private QuestController cont;
    private ColorBlock colors;

    void Start()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();
        cont = GameObject.Find("Quest Controller").GetComponent<QuestController>();
        colors = gameObject.GetComponent<Button>().colors;
        scroll.enabled = false;
    }

    private void Update()
    {
        //Enable quest 4 and 5 if you have over 3k
        if (var.booty >= 3000)
        {
            if (gameObject.name == "Quest4" || gameObject.name == "Quest5")
            {
                colors.disabledColor = Color.white;
                GetComponent<Button>().colors = colors;
            }
        }

        //Enable quest 3 if you've finished quest 2
        if (cont.quest2)
        {
            if(gameObject.name == "Quest3")
            {
                colors.disabledColor = Color.white;
                GetComponent<Button>().colors = colors;
            }
        }

        if ((gameObject.name == "Quest1" && cont.quest1) || (gameObject.name == "Quest2" && cont.quest2) || 
            (gameObject.name == "Quest3" && cont.quest3) || (gameObject.name == "Quest4" && cont.quest4) ||
            (gameObject.name == "Quest5" && cont.quest5))
        {
            colors.disabledColor = Color.green;
            GetComponent<Button>().colors = colors;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        scroll.enabled = true;
        scroll.GetComponent<Animator>().Play("scroll_open");
        scroll.transform.position = new Vector3(transform.position.x + 200f, transform.position.y -
            scroll.GetComponent<RectTransform>().sizeDelta.y * 0.25f / 2 + 30, transform.position.z);

        if (gameObject.name == "Quest1")
        {
            scroll.GetComponentInChildren<Text>().text = "Destroy an enemy ship!";
        }

        if (gameObject.name == "Quest2")
        {
            scroll.GetComponentInChildren<Text>().text = "Upgrade your ship:\n- Level 1 Health\n- Level 1 Attack\n- Level 1 Speed";
        }

        if (gameObject.name == "Quest3")
        {
            scroll.GetComponentInChildren<Text>().text = "Required: Moving Up in the World\n\nFully upgrade your ship.";
        }

        if (gameObject.name == "Quest4")
        {
            scroll.GetComponentInChildren<Text>().text = "Required: $3000\n\nPurchase a tower.";
        }

        if (gameObject.name == "Quest5")
        {
            scroll.GetComponentInChildren<Text>().text = "Required: $3000\n\nWin a round without attacking with your ship.";
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        scroll.enabled = false;
        scroll.GetComponent<Animator>().Play("empty");
        scroll.GetComponentInChildren<Text>().text = "";
    }

}
