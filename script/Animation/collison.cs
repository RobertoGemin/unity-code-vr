using UnityEngine;
using System.Collections;

public class collison : MonoBehaviour {

	// Use this for initialization
	public GameObject stroke;

	void OnTriggerEnter(Collider other) {

		// send massege naar main 
		//Destroy(other.gameObject);
		//checkSymbol script;

		/*

		if (other.name == "start") {
			stroke.SendMessage("checkStartBall");
		}
		if (other.name == "middel") {
			stroke.SendMessage("checkMiddleBall");
		}
		if (other.name == "end") {
			stroke.SendMessage("checkEndBall");
		}
	*/
	}



}
