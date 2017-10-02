using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    public GameObject tower0;
    public GameObject tower1;
    public GameObject tower2;
    private Variables var;

    private Dictionary<string, int> dic;
    public int index;

    // Use this for initialization
    void Start()
    {
        //Create dictionary of tower names
        dic = new Dictionary<string, int>();
        dic.Add("NE", 0);
        dic.Add("E", 1);
        dic.Add("S", 2);
        dic.Add("SW", 3);
        dic.Add("NW", 4);

        dic.TryGetValue(gameObject.name, out index);

        var = GameObject.Find("Variables").GetComponent<Variables>();

        //Hide towers
        tower0.SetActive(false);
        tower1.SetActive(false);
        tower2.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        //Set models
        if (gameObject.name == "NE")
        {
            if (var.levelArray[0] == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.levelArray[0] == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.levelArray[0] == 3)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "E")
        {
            if (var.levelArray[1] == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.levelArray[1] == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.levelArray[1] == 3)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "S")
        {
            if (var.levelArray[2] == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.levelArray[2] == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.levelArray[2] == 3)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "SW")
        {
            if (var.levelArray[3] == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.levelArray[3] == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.levelArray[3] == 3)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "NW")
        {
            if (var.levelArray[4] == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.levelArray[4] == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.levelArray[4] == 3)
            {
                tower2.SetActive(true);
            }
        }
    }
}
