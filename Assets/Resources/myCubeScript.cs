﻿using UnityEngine;
using System.Collections;

public class myCubeScript : MonoBehaviour {
	public Color hoverColor;
	public Color startColor;
    public float ratateSpeed = 0.1f;
    public Vector3 spinSpeed = Vector3.zero;
    Vector3 spinAxis = new Vector3(5, 5, 0);


    // Use this for initialization
    void Start () {
        spinSpeed = new Vector3(Random.value, Random.value, Random.value);
		spinAxis = Vector3.left;
        spinAxis.x = (Random.value - Random.value)*1.1f;
	}
	
    public void setSize(float size)
    {
        this.transform.localScale = new Vector3(size, size, size);
    }

	// Update is called once per frame
	void Update () {
        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero, Vector3.up, ratateSpeed);

	}


	void OnMouseEnter(){
		GetComponent<Renderer> ().material.SetColor ("_Color", hoverColor);
	}

	void OnMouseExit(){
		GetComponent<Renderer> ().material.SetColor ("_Color", startColor);
	}
}





