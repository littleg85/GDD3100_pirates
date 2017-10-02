using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatUpgrade : MonoBehaviour {

    private Variables var;

    //Boats
    public GameObject boat0;
    public GameObject boat1;
    public GameObject boat2;
    public GameObject boat3;
    public GameObject cannons;

    // Use this for initialization
    void Start () {

        var = GameObject.Find("Variables").GetComponent<Variables>();

        //Hide children
        boat0.SetActive(false);
        boat1.SetActive(false);
        boat2.SetActive(false);
        boat3.SetActive(false);
        cannons.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        //Set Models
        if (var.healthLevel == 0)
        {
            boat0.SetActive(true);
        }

        if (var.healthLevel == 1)
        {
            boat1.SetActive(true);
        }

        if (var.healthLevel == 2)
        {
            boat2.SetActive(true);
        }

        if (var.healthLevel == 3)
        {
            boat3.SetActive(true);
        }

        if (var.attackLevel == 2 || var.attackLevel == 3)
        {
            cannons.SetActive(true);
        }
    }
}
