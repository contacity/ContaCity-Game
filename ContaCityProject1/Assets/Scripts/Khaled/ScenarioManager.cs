﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {
	
	public GameObject CarFollow;
	public GameObject Fire1;
	public GameObject Fire2;

	private FollowPathUnit followPathUnit;
	private float delayFire1=4f;
	private float delayFire2=6f;
	private float startTime;


	// Use this for initialization
	void Start () {
		startTime = Time.time;
		Fire1.SetActive (false);
		Fire2.SetActive (false);
		followPathUnit = CarFollow.GetComponent<FollowPathUnit> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			followPathUnit.followPathTrig = true;
			print ("a");
		}

		if (Time.time >= startTime + delayFire1) {
			Fire1.SetActive (true);
		}

		if (Time.time >= startTime + delayFire2) {
			Fire2.SetActive (true);
		}
	}


}
