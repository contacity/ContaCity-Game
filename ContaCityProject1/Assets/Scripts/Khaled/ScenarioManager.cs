using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

	public GameObject CarFollow;
	public GameObject Fire1;
	public GameObject Fire2;
	private FollowPathUnit followPathUnit;
	// Use this for initialization
	void Start () {
		followPathUnit = CarFollow.GetComponent<FollowPathUnit> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.A) ) {
			followPathUnit.followPathTrig = true;
			print ("a");
		}
		Example ();
	}

	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(5);
		Fire1.SetActive (true);
		yield return new WaitForSeconds(5);
		Fire2.SetActive (true);
		print(Time.time);
	}
}
