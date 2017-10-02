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

    //Towers
    public int[] levelArray;

    //Enemy
    public float enemySpeed = 0;


    // Use this for initialization

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        //Start tower levels at 0
        levelArray = new int[5];
        for (int i = 0; i < 5; i++)
        {
            levelArray[i] = 0;
        }

        //Set default keybinds
        KeyBindingManager.keyDict.Add(KeyAction.forward, KeyCode.W);
        KeyBindingManager.keyDict.Add(KeyAction.backward, KeyCode.S);
        KeyBindingManager.keyDict.Add(KeyAction.left, KeyCode.A);
        KeyBindingManager.keyDict.Add(KeyAction.right, KeyCode.D);
        KeyBindingManager.keyDict.Add(KeyAction.attack1, KeyCode.Mouse0);
        KeyBindingManager.keyDict.Add(KeyAction.attack2, KeyCode.Mouse1);
    }
}
