using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class UpgradeUI : MonoBehaviour
{

    private Variables var;
    private UpgradePers up;

    private void Awake()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();

        //Show cursor
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        //Set up buttons
        //Health column
        if (var.healthLevel == 1)
        {
            GameObject.Find("pHealth1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pHealth1").GetComponent<Button>().interactable = false;
            GameObject.Find("pHealth2").GetComponent<Button>().interactable = true;
        }
        if (var.healthLevel == 2)
        {
            GameObject.Find("pHealth1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pHealth2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pHealth1").GetComponent<Button>().interactable = false;
            GameObject.Find("pHealth2").GetComponent<Button>().interactable = false;
            GameObject.Find("pHealth3").GetComponent<Button>().interactable = true;
        }
        if (var.healthLevel == 3)
        {
            GameObject.Find("pHealth1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pHealth2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pHealth3").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pHealth1").GetComponent<Button>().interactable = false;
            GameObject.Find("pHealth2").GetComponent<Button>().interactable = false;
            GameObject.Find("pHealth3").GetComponent<Button>().interactable = false;
        }

        //Attack column
        if (var.attackLevel == 1)
        {
            GameObject.Find("pAttack1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pAttack1").GetComponent<Button>().interactable = false;
            GameObject.Find("pAttack2").GetComponent<Button>().interactable = true;
        }
        if (var.attackLevel == 2)
        {
            GameObject.Find("pAttack1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pAttack2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pAttack1").GetComponent<Button>().interactable = false;
            GameObject.Find("pAttack2").GetComponent<Button>().interactable = false;
            GameObject.Find("pAttack3").GetComponent<Button>().interactable = true;
        }
        if (var.attackLevel == 3)
        {
            GameObject.Find("pAttack1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pAttack2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pAttack3").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pAttack1").GetComponent<Button>().interactable = false;
            GameObject.Find("pAttack2").GetComponent<Button>().interactable = false;
            GameObject.Find("pAttack3").GetComponent<Button>().interactable = false;
        }

        //Attack Speed column
        if (var.fireRate == 1.5f)
        {
            GameObject.Find("aSpeed1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("aSpeed1").GetComponent<Button>().interactable = false;
            GameObject.Find("aSpeed2").GetComponent<Button>().interactable = true;
        }
        if (var.fireRate == 1f)
        {
            GameObject.Find("aSpeed1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("aSpeed2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("aSpeed1").GetComponent<Button>().interactable = false;
            GameObject.Find("aSpeed2").GetComponent<Button>().interactable = false;
            GameObject.Find("aSpeed3").GetComponent<Button>().interactable = true;
        }
        if (var.fireRate == 0.5f)
        {
            GameObject.Find("aSpeed1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("aSpeed2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("aSpeed3").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("aSpeed1").GetComponent<Button>().interactable = false;
            GameObject.Find("aSpeed2").GetComponent<Button>().interactable = false;
            GameObject.Find("aSpeed3").GetComponent<Button>().interactable = false;
        }

        //Speed column
        if (var.speed == 40000)
        {
            GameObject.Find("pSpeed1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pSpeed1").GetComponent<Button>().interactable = false;
            GameObject.Find("pSpeed2").GetComponent<Button>().interactable = true;
        }
        if (var.speed == 60000)
        {
            GameObject.Find("pSpeed1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pSpeed2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pSpeed1").GetComponent<Button>().interactable = false;
            GameObject.Find("pSpeed2").GetComponent<Button>().interactable = false;
            GameObject.Find("pSpeed3").GetComponent<Button>().interactable = true;
        }
        if (var.speed == 80000)
        {
            GameObject.Find("pSpeed1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pSpeed2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pSpeed3").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("pSpeed1").GetComponent<Button>().interactable = false;
            GameObject.Find("pSpeed2").GetComponent<Button>().interactable = false;
            GameObject.Find("pSpeed3").GetComponent<Button>().interactable = false;
        }

        //Mobility column
        if (var.turnSpeed == 50)
        {
            GameObject.Find("Mob1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("Mob1").GetComponent<Button>().interactable = false;
            GameObject.Find("Mob2").GetComponent<Button>().interactable = true;
        }
        if (var.turnSpeed == 75)
        {
            GameObject.Find("Mob1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("Mob2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("Mob1").GetComponent<Button>().interactable = false;
            GameObject.Find("Mob2").GetComponent<Button>().interactable = false;
            GameObject.Find("Mob3").GetComponent<Button>().interactable = true;
        }
        if (var.turnSpeed == 100)
        {
            GameObject.Find("Mob1").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("Mob2").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("Mob3").GetComponent<Button>().image.color = Color.green;
            GameObject.Find("Mob1").GetComponent<Button>().interactable = false;
            GameObject.Find("Mob2").GetComponent<Button>().interactable = false;
            GameObject.Find("Mob3").GetComponent<Button>().interactable = false;
        }
    }


    public void OnStartGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Scene Loaded");
    }

    public void PlayerHealth()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "pHealth1")
        {
            if (var.booty >= 1000)
            {
                var.healthLevel = 1;
                Debug.Log("Health Level 1");
                var.booty -= 1000;
                up.hp1 = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "pHealth2")
        {
            if (var.booty >= 2000)
            {
                var.healthLevel = 2;
                Debug.Log("Health Level 2");
                var.booty -= 2000;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "pHealth3")
        {
            if (var.booty >= 3000)
            {
                var.healthLevel = 3;
                Debug.Log("Health Level 3");
                var.booty -= 3000;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }
    }

    public void PlayerAttack()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "pAttack1")
        {
            if (var.booty >= 1000)
            {
                var.attackLevel = 1;
                Debug.Log("Attack Level 1");
                var.booty -= 1000;
                GameObject.Find("pAttack1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack1").GetComponent<Button>().interactable = false;
                GameObject.Find("pAttack2").GetComponent<Button>().interactable = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "pAttack2")
        {
            if (var.booty >= 2000)
            {
                var.attackLevel = 2;
                Debug.Log("Attack Level 2");
                var.booty -= 2000;
                GameObject.Find("pAttack2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack2").GetComponent<Button>().interactable = false;
                GameObject.Find("pAttack3").GetComponent<Button>().interactable = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "pAttack3")
        {
            if (var.booty >= 3000)
            {
                var.attackLevel = 3;
                Debug.Log("Attack Level 3");
                var.booty -= 3000;
                GameObject.Find("pAttack3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pAttack3").GetComponent<Button>().interactable = false;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }
    }

    public void PlayerAttackSpeed()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "aSpeed1")
        {
            if (var.booty >= 1000)
            {
                var.fireRate = 1.5f;
                Debug.Log("Attack Speed Level 1");
                var.booty -= 1000;
                GameObject.Find("aSpeed1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed1").GetComponent<Button>().interactable = false;
                GameObject.Find("aSpeed2").GetComponent<Button>().interactable = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "aSpeed2")
        {
            if (var.booty >= 2000)
            {
                var.fireRate = 1f;
                Debug.Log("Attack Speed Level 2");
                var.booty -= 2000;
                GameObject.Find("aSpeed2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed2").GetComponent<Button>().interactable = false;
                GameObject.Find("aSpeed3").GetComponent<Button>().interactable = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "aSpeed3")
        {
            if (var.booty >= 3000)
            {
                var.fireRate = 0.5f;
                Debug.Log("Attack Speed Level 3");
                var.booty -= 3000;
                GameObject.Find("aSpeed3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("aSpeed3").GetComponent<Button>().interactable = false;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }
    }

    public void PlayerSpeed()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "pSpeed1")
        {
            if (var.booty >= 1000)
            {
                var.speed = 40000;
                Debug.Log("Speed Level 1");
                var.booty -= 1000;
                GameObject.Find("pSpeed1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed1").GetComponent<Button>().interactable = false;
                GameObject.Find("pSpeed2").GetComponent<Button>().interactable = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "pSpeed2")
        {
            if (var.booty >= 2000)
            {
                var.speed = 60000;
                Debug.Log("Speed Level 2");
                var.booty -= 2000;
                GameObject.Find("pSpeed2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed2").GetComponent<Button>().interactable = false;
                GameObject.Find("pSpeed3").GetComponent<Button>().interactable = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "pSpeed3")
        {
            if (var.booty >= 3000)
            {
                var.speed = 80000;
                Debug.Log("Speed Level 3");
                var.booty -= 3000;
                GameObject.Find("pSpeed3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("pSpeed3").GetComponent<Button>().interactable = false;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }
    }

    public void PlayerMobility()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "Mob1")
        {
            if (var.booty >= 1000)
            {
                var.turnSpeed = 50;
                Debug.Log("Mobility Level 1");
                var.booty -= 1000;
                GameObject.Find("Mob1").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob1").GetComponent<Button>().interactable = false;
                GameObject.Find("Mob2").GetComponent<Button>().interactable = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }

        }

        if (EventSystem.current.currentSelectedGameObject.name == "Mob2")
        {
            if (var.booty >= 2000)
            {
                var.turnSpeed = 75;
                Debug.Log("Mobility Level 2");
                var.booty -= 2000;
                GameObject.Find("Mob2").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob2").GetComponent<Button>().interactable = false;
                GameObject.Find("Mob3").GetComponent<Button>().interactable = true;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "Mob3")
        {
            if (var.booty >= 3000)
            {
                var.turnSpeed = 100;
                Debug.Log("Mobility Level 3");
                var.booty -= 3000;
                GameObject.Find("Mob3").GetComponent<Button>().image.color = Color.green;
                GameObject.Find("Mob3").GetComponent<Button>().interactable = false;
            }
            else
            {
                Debug.Log("Not enough booty");
            }
        }
    }

    public void Difficulty()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "diff1")
        {
            var.difficulty = 0;
            Debug.Log("Difficulty Level 1");
        }

        if (EventSystem.current.currentSelectedGameObject.name == "diff2")
        {
            var.difficulty = 1;
            Debug.Log("Difficulty Level 2");
        }

        if (EventSystem.current.currentSelectedGameObject.name == "diff3")
        {
            var.difficulty = 2;
            Debug.Log("Difficulty Level 3");
        }

        if (EventSystem.current.currentSelectedGameObject.name == "diff4")
        {
            var.difficulty = 3;
            Debug.Log("Difficulty Level 4");
        }
    }

}
