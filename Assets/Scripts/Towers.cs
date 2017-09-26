using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour {

    public GameObject tower0;
    public GameObject tower1;
    public GameObject tower2;



    // Use this for initialization
    void Start () {

        //Hide towers
        tower0.SetActive(false);
        tower1.SetActive(false);
        tower2.SetActive(false);

        //Set models
        if (gameObject.name == "NE")
        {

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
