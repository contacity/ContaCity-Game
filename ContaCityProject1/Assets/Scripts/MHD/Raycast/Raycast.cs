using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

//	public Transform sightStart, sightEnd;
//	public bool spotted = false;
	public GameObject objectHit;

	// Use this for initialization
	void Start () {
		
	}	
	// Update is called once per frame
	void Update () {
		
			if (Input.GetMouseButtonDown(0))
			{
			objectHit = CheckObject() ;
			}
	//	Raycasting ();
	}
	GameObject CheckObject() 
	{
		//Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
	///	RaycastHit hit;
		Vector2 origin = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
			Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.zero, 1000f);
		if (hit){
			Debug.DrawLine (origin, Vector2.zero, Color.green);
			//LayerMask.NameToLayer ("Bulding");
			//		return Physics2D.Raycast(origin, Vector2.zero, float.PositiveInfinity, layerMask);
			//Debug.LogWarning ("hit");
			Debug.Log(hit.transform.name);
			return hit.transform.gameObject;

		        }//End if
		//Debug.LogWarning ("hit");
		//	}
		else return null;
		}
}
