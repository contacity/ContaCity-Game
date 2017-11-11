using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFF : MonoBehaviour {
	public GameObject lighter;
	public GameObject fB1Button;
	// Use this for initialization
	void Start () {
		lighter.SetActive (false);
		fB1Button.SetActive (false);
	}
	
	// Update is called once per frame
	public void TriggleFB1 () {
		if (lighter.activeSelf == true) {
			lighter.SetActive (false);
			fB1Button.SetActive (false);
		} else{
			lighter.SetActive (true);
			fB1Button.SetActive (true);
	}
	}
	}
