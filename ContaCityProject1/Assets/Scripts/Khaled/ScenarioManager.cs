using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

	public GameObject CarFollow;
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
	}
}
