using UnityEngine;
using System.Collections;

public class groupballCollison : MonoBehaviour {


	public int idCount;
	public GameObject getparent;
	void OnTriggerEnter(Collider other){
	//	Debug.Log (other.name);

		getparent = transform.parent.gameObject;
		//Debug.Log (other.name);
		if (other.name == "hand") {
			getparent.SendMessage("checkIDBall",idCount);
		}
	}
}
