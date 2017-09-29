using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour {

    public GameObject tower0;
    public GameObject tower1;
    public GameObject tower2;
    private Variables var;
    private float dist;
    private GameLogic logic;
    private GameObject closestEnemy;


    // Use this for initialization
    void Start () {

        var = GameObject.Find("Variables").GetComponent<Variables>();
        logic = GameObject.Find("GameUI").GetComponent<GameLogic>();

        //Hide towers
        tower0.SetActive(false);
        tower1.SetActive(false);
        tower2.SetActive(false);

        //Set models
        if (gameObject.name == "NE")
        {
            if (var.NElevel == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.NElevel == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.NElevel == 2)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "NW")
        {
            if (var.NWlevel == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.NWlevel == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.NWlevel == 2)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "S")
        {
            if (var.Slevel == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.Slevel == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.Slevel == 2)
            {
                tower2.SetActive(true);
            }

            if (gameObject.name == "E")
            {
                if (var.Elevel == 1)
                {
                    tower0.SetActive(true);
                }
                else if (var.Elevel == 2)
                {
                    tower1.SetActive(true);
                }
                else if (var.Elevel == 2)
                {
                    tower2.SetActive(true);
                }
            }

            if (gameObject.name == "SW")
            {
                if (var.SWlevel == 1)
                {
                    tower0.SetActive(true);
                }
                else if (var.SWlevel == 2)
                {
                    tower1.SetActive(true);
                }
                else if (var.SWlevel == 2)
                {
                    tower2.SetActive(true);
                }
            }
        }

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 position = transform.position;
        dist = Vector3.Distance(logic.enemies[0].transform.position, transform.position);
        for (int i = 0; i <= logic.enemies.Length; i++)
        {
            float tempDist = Vector3.Distance(logic.enemies[i].transform.position, transform.position);
            if (tempDist <= dist)
            {
                closestEnemy = logic.enemies[i];
            }
        }
        foreach (GameObject enemy in logic.enemies)
        {
            dist = enemy.transform.position - position
        }
    }
}
