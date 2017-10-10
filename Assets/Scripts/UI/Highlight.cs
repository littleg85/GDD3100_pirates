using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Highlight : MonoBehaviour
{

    private Renderer rend;
    public bool selected = false;
    public GameObject upgrade;
    private Variables var;
    public GameObject myTower;
    public int cost;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
        var = GameObject.Find("Variables").GetComponent<Variables>();
        GameObject.Find("Tower Upgrade Manager").GetComponent<ListOfHighlights>().hightlights.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            upgrade.SetActive(true);
            if (var.levelArray[myTower.GetComponent<TowerUpgrade>().index] == 0)
            {
                cost = 3000;
            }
            else if (var.levelArray[myTower.GetComponent<TowerUpgrade>().index] == 1)
            {
                cost = 6000;
            }
            else if (var.levelArray[myTower.GetComponent<TowerUpgrade>().index] == 2)
            {
                cost = 9000;
            }
            else
            {
                cost = 0;
            }
        }
        else
        {
            cost = 0;
        }
    }

    private void OnMouseEnter()
    {
        if (!selected)
        {
            rend.enabled = true;
            Color mouseOver = Color.green;
            //mouseOver.a = 0.1f;
            rend.material.color = mouseOver;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !selected)
        {
            Color mouseOver = Color.red;
            //mouseOver.a = 0.3f;
            rend.material.color = mouseOver;
            selected = true;
        }
        else if (Input.GetMouseButtonDown(0) && selected)
        {
            Color mouseOver = Color.green;
           // mouseOver.a = 0.1f;
            rend.material.color = mouseOver;
            upgrade.SetActive(false);
            selected = false;
        }
    }

    private void OnMouseExit()
    {
        if (!selected)
        {
            rend.enabled = false;
        }
    }

    public void Upgrade()
    {
        if (selected)
        {
            if (var.levelArray[myTower.GetComponent<TowerUpgrade>().index] == 0 && var.booty >= 3000)
            {
                var.booty -= 3000;
                var.levelArray[myTower.GetComponent<TowerUpgrade>().index]++;
            }
            else if (var.levelArray[myTower.GetComponent<TowerUpgrade>().index] == 1 && var.booty >= 6000)
            {
                var.booty -= 6000;
                var.levelArray[myTower.GetComponent<TowerUpgrade>().index]++;
            }
            else if (var.levelArray[myTower.GetComponent<TowerUpgrade>().index] == 2 && var.booty >= 9000)
            {
                var.booty -= 9000;
                var.levelArray[myTower.GetComponent<TowerUpgrade>().index]++;
            }
        }
    }
}
