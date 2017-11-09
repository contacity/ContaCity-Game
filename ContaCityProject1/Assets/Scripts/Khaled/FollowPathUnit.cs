using UnityEngine;
using System.Collections;

public class FollowPathUnit : MonoBehaviour {

    public bool pathLoop = false;

    public bool reversePath = false;

    public LinePath path;

	[HideInInspector]
	public bool followPathTrig;

    private SteeringBasics steeringBasics;
    private FollowPath followPath;

    // Use this for initialization
    void Start () {
        path.calcDistances();
		print ("start");
        steeringBasics = GetComponent<SteeringBasics>();
        followPath = GetComponent<FollowPath>();
    }
	
	// Update is called once per frame
	void Update () {
		if ( followPathTrig == true) {
			print ("followpathUnit Done");
			path.draw ();

			if (reversePath && isAtEndOfPath ()) {
				path.reversePath ();
			}

			Vector3 accel = followPath.getSteering (path, pathLoop);
			print ("update");
			steeringBasics.steer (accel);
			steeringBasics.lookWhereYoureGoing ();
		}
    }

    public bool isAtEndOfPath()
    {
        return Vector3.Distance(path.endNode, transform.position) < followPath.stopRadius;
    }
}
