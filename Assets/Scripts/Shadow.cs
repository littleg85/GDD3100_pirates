﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player.transform);
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}
