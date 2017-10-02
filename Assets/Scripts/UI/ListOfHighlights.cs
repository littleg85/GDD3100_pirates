using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfHighlights : MonoBehaviour {

    public List<Highlight> hightlights;

	// Use this for initialization
	void Awake () {

        hightlights = new List<Highlight>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Upgrade()
    {
        foreach(Highlight highlight in hightlights)
        {
            highlight.Upgrade();
        }
    }
}
