using UnityEngine;
using System.Collections;

public class testAnimation : MonoBehaviour {

	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.U)) {
			anim.SetInteger ("ani", 0);
		
		}
	
		if (Input.GetKey (KeyCode.I)) {
			anim.SetInteger ("ani", 1);

		}

		if (Input.GetKey (KeyCode.O)) {
			anim.SetInteger ("ani", 2);

		}

		if (Input.GetKey (KeyCode.P)) {
			anim.SetInteger ("ani", 3);

		}


	}
}
