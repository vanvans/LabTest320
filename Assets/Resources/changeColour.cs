using UnityEngine;
using System.Collections;

public class changeColour : MonoBehaviour {
	public Color startColor;
	public Color mouseOverColor;

	bool mouseOver = false;

	// Use this for initialization
	void OnMouseDown() {
		mouseOver = true;
		GetComponent<Renderer>().material.SetColor ("_Color", mouseOverColor);
	}
	
	// Update is called once per frame
	void OnMouseExit() {
		mouseOver = false;
		GetComponent<Renderer>().material.SetColor ("_Color", startColor);
	
	}
		


}

