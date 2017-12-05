using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PauseMenuQuests : MonoBehaviour
{

    private QuestController cont;

    void Start()
    {

        cont = GameObject.Find("Quest Controller").GetComponent<QuestController>();

    }

    // Update is called once per frame
    void Update()
    {

        if (name == "quest1Text" && cont.quest1)
        {
            gameObject.GetComponent<Text>().color = Color.green;
        }
        if (name == "quest2Text" && cont.quest2)
        {
            gameObject.GetComponent<Text>().color = Color.green;
        }
        if (name == "quest3Text" && cont.quest3)
        {
            gameObject.GetComponent<Text>().color = Color.green;
        }
        if (name == "quest4Text" && cont.quest4)
        {
            gameObject.GetComponent<Text>().color = Color.green;
        }
        if (name == "quest5Text" && cont.quest5)
        {
            gameObject.GetComponent<Text>().color = Color.green;
        }

    }
}
