﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour {

	public Slider slider;
	public bool fire = false;
	public float hvalue=10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (fire) {
		//	Debug.LogWarning ("P");
			 Health();
		}
	}

	void Health(){
		slider = GetComponent<Slider> ();
		slider.value -= 0.4f*Time.deltaTime;
		hvalue = slider.value;
	}
}

