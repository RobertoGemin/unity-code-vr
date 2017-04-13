using UnityEngine;
using System.Collections;

public class LookAtMonk : MonoBehaviour {
	public GameObject step0;
	public bool lookAtFunction;
	// Use this for initialization
	StoryScript sendCheckBack;

	void Start () {
		lookAtFunction = false;
		sendCheckBack = GetComponent<StoryScript> ();
	}
	void Update () {
		if (lookAtFunction == true) {
			sceneWaitLook ();
		}
	}
	void sceneWaitLook(){
		if (GeometryUtility.TestPlanesAABB (GeometryUtility.CalculateFrustumPlanes (Camera.main), step0.GetComponent<Collider> ().bounds)) {
			lookAtFunction = false; //Debug.Log ("look at monk clear");
			sendCheckBack.isProgressCheck = true;	
		}

	}

	public void lookActive (){
		lookAtFunction = true;

	}


}
