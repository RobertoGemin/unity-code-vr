using UnityEngine;
using System.Collections;

public class monkIdle : MonoBehaviour {
	public Animator anim;
	void Start () {
		anim = GetComponent<Animator>();
	}
	public void changeMovement(int move){
		anim.SetInteger ("ani",move);	
	}

}
