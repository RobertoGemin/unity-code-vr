using UnityEngine;
using System.Collections;

public class moveBoat : MonoBehaviour {

	public Animator anim;
	void Start () {
		anim = GetComponent<Animator>();
	}
	public void boatMove(){
		anim.SetBool ("start", true);
	}
	public void boatReset(){
		anim.SetBool ("start", false);
	}

}
