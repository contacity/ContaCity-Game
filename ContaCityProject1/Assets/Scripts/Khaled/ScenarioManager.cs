using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {
	
	public GameObject carFollow1;
	private FollowPathUnit carFollow1Path;


	public GameObject carFollow2;
	private FollowPathUnit carFollow2Path;


	public int tBB=0;
	public int tFT=0;

	/*public GameObject ordinaryCar1;
	private FollowPathUnit ordinaryCar1Path;

	public GameObject ordinaryCar2;	
	private FollowPathUnit ordinaryCar2Path;

	public GameObject ordinaryCar3;
	private FollowPathUnit ordinaryCar3Path;*/

	public GameObject fire1;
	public GameObject fire1Col;
	public GameObject fire1Health;
	public HealthSlider hf1;
	private float delayFire1=2f;

	public GameObject fire2;
	public GameObject fire2Col;
	public GameObject fire2Health;
	public HealthSlider hf2;
	private float delayFire2=4f;

	private float startTime;

	public GameObject Lose ;
	public GameObject Win ; 


	// Use this for initialization
	void Start () {
		startTime = Time.time;
		fire1.SetActive (false);
		fire2.SetActive (false);
		carFollow1Path = carFollow1.GetComponent<FollowPathUnit> ();
		carFollow2Path = carFollow2.GetComponent<FollowPathUnit> ();
		hf1 = fire1Health.GetComponent<HealthSlider> ();
		hf2 = fire2Health.GetComponent<HealthSlider> ();
	}
	
	// Update is called once per frame
	void Update () {
		CheckWinLose ();
		FireMaker ();
			
	}
		

	public void FireMaker (){
		if (Time.time >= startTime + delayFire1) {
			fire1.SetActive (true);
			fire1Col.SetActive (true);
			fire1Health.SetActive (true);
		}

		if (Time.time >= startTime + delayFire2) {
			fire2.SetActive (true);
			fire2Col.SetActive (true);
			fire2Health.SetActive (true);
		}
	}

	public void TargetFT ( int t ) {
		tFT = t ;
	}

	public void TargetBB ( int f ) {
		tBB = f ;
		ChoosePath ();
	}

	public void ChoosePath () {
		if (tFT==1 && tBB ==1) {
			carFollow1Path.followPathTrig = true;
			carFollow1Path.pathn = carFollow1Path.path1;
			tFT = 0;
			tBB = 0;
		}
		else if (tFT==1 && tBB ==2) {
			carFollow1Path.followPathTrig = true;
			carFollow1Path.pathn = carFollow1Path.path2;
			tFT = 0;
			tBB = 0;
		}
		else if (tFT==2 && tBB ==1) {
			carFollow2Path.followPathTrig = true;
			carFollow2Path.pathn = carFollow2Path.path1;
			tFT = 0;
			tBB = 0;
		}
		else if (tFT==2 && tBB ==2) {
			carFollow2Path.followPathTrig = true;
			carFollow2Path.pathn = carFollow2Path.path2;
			tFT = 0;
			tBB = 0;
		}

	}

	public void CheckWinLose (){
		if (hf1.hvalue == 0 && hf2.hvalue == 0) {
			Lose.SetActive (true);
		}
	}

}


