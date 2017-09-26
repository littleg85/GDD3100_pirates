using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

    //Make script accessible
    public static Variables var;

    //Gold earned
    public int booty = 0;

    //Upgrades
    //---------------------------
    //Attack
    public int attackLevel = 0;
    //Health
    public int healthLevel = 0;
    //Utility
    public int speedLevel = 0;
    public int tSpeedLevel = 0;
    public int aSpeedLevel = 0;

    //Enemy
    public float enemySpeed = 0;

    //Stage
    public int difficulty = 0;

    // Use this for initialization

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
