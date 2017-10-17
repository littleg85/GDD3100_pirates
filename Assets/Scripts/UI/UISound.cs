using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UISound : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{

    private AudioSource[] sounds;
    private AudioSource mouseover;
    private AudioSource click;
    private AudioSource deny;
    private Button button;

    private GamepadController contr;
    private GameObject store;

    private void Start()
    {
        contr = GameObject.Find("Gamepad Controller").GetComponent<GamepadController>();
        store = EventSystem.current.currentSelectedGameObject;

        button = GetComponent<Button>();
        sounds = GameObject.Find("Sound Controller").GetComponents<AudioSource>();
        mouseover = sounds[0];
        click = sounds[1];
        deny = sounds[2];
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseover.Play();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (button.interactable == true)
        {
            click.Play();
        }
        else
        {
            deny.Play();
        }    
    }

    private void Update()
    {
        if (contr.xbox == 1)
        {       
            if (EventSystem.current.currentSelectedGameObject != store)
            {
                store = EventSystem.current.currentSelectedGameObject;
                mouseover.Play();
            }
        }
    }
}
