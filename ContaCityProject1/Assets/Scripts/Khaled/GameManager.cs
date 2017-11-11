using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public Text Score;
	public Text Money;
	public int NScore=10;
	public int NMoney=150;

	public Text FT1_Num;
	public int nFT1_Num;
	public Text FT2_Num;
	public int nFT2_Num;

	public GameObject fireTruck1;
	public GameObject fireTruck1Col;
	public GameObject fireTruck2; 
	public GameObject fireTruck2Col;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void BuyMidTruck(){
		NMoney -= 50;
		Money.text = "Money : " + NMoney + "K $";
		nFT1_Num += 1;
		FT1_Num.text = ""+nFT1_Num;
	}

	public void BuyBigTruck(){
		NMoney -= 100;
		Money.text = "Money : " + NMoney + "K $";
		nFT2_Num += 1;
		FT2_Num.text = ""+nFT2_Num;
	}


	public void MidTruckBut(){
		if (nFT1_Num>0) {
			nFT1_Num -= 1;
			FT1_Num.text = "" + nFT1_Num;
			fireTruck1.SetActive (true);
			fireTruck1Col.SetActive (true);
		}
	}

	public void BigTruckBut(){
		if (nFT2_Num > 0) {
			nFT2_Num -= 1;
			FT2_Num.text = "" + nFT2_Num;
			fireTruck2.SetActive (true);
			fireTruck2Col.SetActive (true);
		}
	}



	public void WinLevel ()
	{
		NMoney += 200;
		Money.text = "Money : " + NMoney + "K $";
		NScore += 20;
		Score.text = "Score : " + NScore; 

	}
}
