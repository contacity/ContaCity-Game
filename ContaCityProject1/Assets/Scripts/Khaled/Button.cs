using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
	public GameObject lighter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void phbu () {
		if (lighter.activeSelf == true) {
			lighter.SetActive(false);
		} else
			lighter.SetActive(true);
	}
	}
