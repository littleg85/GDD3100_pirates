using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyInfo : MonoBehaviour {

    private int level;
    private int remaining;
	
	void Update () {

        remaining = GameObject.Find("GameUI").GetComponent<GameLogic>().enemies.Length;
        level = GameObject.Find("GameUI").GetComponent<EnemySpawner>().difficulty;

        if (gameObject.name == "EnemyInfoLevel")
        {
            gameObject.GetComponent<Text>().text = "Level:" + level;
        }

        if (gameObject.name == "EnemyInfoRemain")
        {
            gameObject.GetComponent<Text>().text = "Remaining:" + remaining;
        }

    }
}
