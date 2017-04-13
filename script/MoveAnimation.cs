using UnityEngine;
using System.Collections;

public class MoveAnimation : MonoBehaviour {


	public Animator anim;
	public GameObject monk;
	public MonkAudioScript monkTalk;
	public GameObject scriptHolder;
	public bool startMoving;
	public bool startgreet;
	public bool flower;
	void Start () {
		anim = GetComponent<Animator>();

		monkTalk =  GetComponent<MonkAudioScript> ();
		//monk.GetComponent<monkIdle>().changeMovement (count);

	}
	public void monkMove(){
		/*
		//anim.GetBool(
		anim.SetBool  ("start", true);
		anim.SetBool  ("flower", false);
		anim.SetBool  ("secondFlower", false);
		startMoving = true;
		startgreet = true;
		flower = true;
		*/
	}
	public void givingFlower(){
		/*
		anim.SetBool  ("start", false);
		anim.SetBool  ("flower", true);
		anim.SetBool  ("secondFlower", false);
		*/
	}
	public void givingFlowerSecond(){
		/*
		anim.SetBool  ("start", false);
		anim.SetBool  ("flower", false);
		anim.SetBool  ("secondFlower", true);
		*/
	}
	void Update () {
		//Debug.Log (anim.GetCurrentAnimatorStateInfo (0).IsName ("skipping"));
		/*
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("skipping")) {
			monk.GetComponent<monkIdle> ().changeMovement (2);
		}
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("greet")) {
			
			monk.GetComponent<monkIdle> ().changeMovement (3);
			Debug.Log ("speak");
			if (startgreet == true) {
				//monkTalk.MonkSpeak (0);
				//MonkAudioScript.GetComponent<MonkAudioScript> ().MonkSpeak (3);
				startgreet = false;

			}
		}
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("walk")) {
			monk.GetComponent<monkIdle> ().changeMovement (6);
		}

		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("wait")) {
			monk.GetComponent<monkIdle> ().changeMovement (0);
			if (startMoving == true) {
				scriptHolder.GetComponent<StoryScript> ().isProgressCheck = true;
				startMoving = false;
			}
		}
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("flower")) {

			if (flower == true) {
				//monkTalk.MonkSpeak (3);
				//MonkAudioScript.GetComponent<MonkAudioScript> ().MonkSpeak (3);
				flower = false;
			}

			monk.GetComponent<monkIdle> ().changeMovement (5);
		}
	*/}




}
