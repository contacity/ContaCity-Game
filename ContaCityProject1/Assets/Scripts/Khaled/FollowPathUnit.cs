using UnityEngine;
using System.Collections;

public class FollowPathUnit : MonoBehaviour {

    public bool pathLoop = false;

    public bool reversePath = false;

    public LinePath path1;
	public LinePath path2;
	[HideInInspector]
	public LinePath pathn;
	[HideInInspector]
	public bool followPathTrig;

    private SteeringBasics steeringBasics;
    private FollowPath followPath;

    // Use this for initialization
    void Start () {
        path1.calcDistances();
		path2.calcDistances();

		print ("start");
        steeringBasics = GetComponent<SteeringBasics>();
        followPath = GetComponent<FollowPath>();
    }
	
	// Update is called once per frame
	void Update () {
		if ( followPathTrig == true) {
			GoPathSelect (pathn);
		}
    }


	public void Trig ()
	{
		this.followPathTrig=true;
	}
		

	public void GoPathSelect (LinePath pathn){
		print ("followpathUnit Done");
		pathn.draw ();

		if (reversePath && isAtEndOfPath (pathn)) {
			pathn.reversePath ();
		}

		Vector3 accel = followPath.getSteering (pathn, pathLoop);
		print ("update");
		steeringBasics.steer (accel);
		steeringBasics.lookWhereYoureGoing ();
	}


	public bool isAtEndOfPath(LinePath pathn)
    {
        return Vector3.Distance(pathn.endNode, transform.position) < followPath.stopRadius;
    }
}
