using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class QuestController : MonoBehaviour
{

    public bool quest1 = false;
    public bool quest2 = false;
    public bool quest3 = false;
    public bool quest4 = false;
    public bool quest5 = false;

    private bool quest1popped = false;
    private bool quest2popped = false;
    private bool quest3popped = false;
    private bool quest4popped = false;
    private bool quest5popped = false;

    //Instantiate popup
    public GameObject popUpPrefab;
    private float fadeTime = 3f;

    //Audio
    public AudioSource achiev;

    private Variables var;

    public void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        var = GameObject.Find("Variables").GetComponent<Variables>();
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Upgrades_v2")
        {
            if (var.attackLevel >= 1 && var.healthLevel >= 1 && var.speedLevel >= 1)
            {
                quest2 = true;
            }

            if (var.attackLevel == 3 && var.healthLevel == 3 && var.speedLevel == 3 && var.aSpeedLevel == 3 && var.tSpeedLevel == 3)
            {
                quest3 = true;
            }
        }

        if ((quest1 && !quest1popped) || (quest2 && !quest2popped) || (quest3 && !quest3popped) ||
            (quest4 && !quest4popped) || (quest5 && !quest5popped))
        {
            StartCoroutine(FadeIn());
        }
    }

    IEnumerator FadeIn()
    {
        //Play sound
        achiev.Play();

        //Instantiate popup
        GameObject popUp = Instantiate(popUpPrefab);
        popUp.transform.SetParent(GameObject.Find("Canvas").transform);
        popUp.GetComponent<RectTransform>().anchoredPosition = new Vector3(225, -100, 0);

        //Set text and say that it has been popped up
        if (quest1 && !quest1popped)
        {
            popUp.GetComponentInChildren<Text>().text = "Battlestations";
            quest1popped = true;
        }

        if (quest2 && !quest2popped)
        {
            popUp.GetComponentInChildren<Text>().text = "Moving Up in the World";
            quest2popped = true;
        }

        if (quest3 && !quest3popped)
        {
            popUp.GetComponentInChildren<Text>().text = "King of the Pirates";
            quest3popped = true;
        }

        if (quest4 && !quest4popped)
        {
            popUp.GetComponentInChildren<Text>().text = "That's Not a Lighthouse";
            quest4popped = true;
        }

        if (quest5 && !quest5popped)
        {
            popUp.GetComponentInChildren<Text>().text = "Wake Me Up When It's Over";
            quest5popped = true;
        }

        //Fade in popup
        Color c_i = popUp.GetComponent<Image>().color;
        Color c_t = popUp.GetComponentInChildren<Text>().color;
        float elapsedTime = 0.0f;

        while (elapsedTime < fadeTime)
        {
            elapsedTime += Time.deltaTime;
            c_i.a += Time.deltaTime;
            c_t.a += Time.deltaTime;
            popUp.GetComponent<Image>().color = c_i;
            popUp.GetComponentInChildren<Text>().color = c_t;
            yield return null;
        }

        //Fade out
        elapsedTime = 0f;
        while (elapsedTime < fadeTime)
        {
            elapsedTime += Time.deltaTime;
            c_i.a -= Time.deltaTime;
            c_t.a -= Time.deltaTime;
            popUp.GetComponent<Image>().color = c_i;
            popUp.GetComponentInChildren<Text>().color = c_t;
            yield return null;
        }

        Destroy(popUp);
    }

}
