﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Used to render GUI text.*/

public class ShowGUI : MonoBehaviour {

	public UnityEngine.TextMesh text;

	// Use this for initialization
	void Start () {
		text = GetComponent<TextMesh> ();				// Gets the current TextMesh component.
		text.GetComponent<Renderer> ().enabled = false;	// Renders the TextMesh component.
	}

	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnTriggerEnter2D(Collider2D other){							// This object makes contact with another objects collider
		
		if(other.name == "Player"){										// The other objects is tagged as player
			text.GetComponent<Renderer>().enabled = true;
		}
	}
		
}
