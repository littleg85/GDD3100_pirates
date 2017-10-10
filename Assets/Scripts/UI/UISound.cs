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


    private void Start()
    {
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
}
