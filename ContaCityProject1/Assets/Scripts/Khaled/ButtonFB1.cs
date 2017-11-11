using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFB1 : MonoBehaviour {
	public GameObject rightMenu;
	public GameObject fFButton;


	public GameObject fTMenu;

	public GameObject fT1Button;
	public GameObject fT1ButtonPlus;
	public GameObject fT1Num;

	public GameObject fT2Button;
	public GameObject fT2ButtonPlus;
	public GameObject fT2Num;

	void Start () {
	
		rightMenu.SetActive (true);
		fFButton.SetActive (true);

		fT1Button.SetActive (false);
		fT1ButtonPlus.SetActive (false);
		fT1Num.SetActive (false);

		fT2Button.SetActive (false);
		fT2ButtonPlus.SetActive (false);
		fT2Num.SetActive (false);

		fTMenu.SetActive (false);
	
	}


	public void Disable_RM () {
		/*if (lighter.activeSelf == true) {
			lighter.SetActive (false);
			FBButton.SetActive (false);
		} else{*/
		rightMenu.SetActive (false);
		fFButton.SetActive (false);

		fT1Button.SetActive (true);
		fT1ButtonPlus.SetActive (true);
		fT1Num.SetActive (true);

		fT2Button.SetActive (true);
		fT2ButtonPlus.SetActive (true);
		fT2Num.SetActive (true);

		fTMenu.SetActive (true);


	}
}
