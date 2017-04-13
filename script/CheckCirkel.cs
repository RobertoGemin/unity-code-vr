using UnityEngine;
using System.Collections;

public class CheckCirkel : MonoBehaviour {
	
	public bool [] ballcheck;
	public GameObject Model;
	public GameObject exempleModel;
	public GameObject BluePlant;
	public GameObject BlueRed;
	public GameObject lookforscript;


	void Start () {
		
		Model.active = false;
		exempleModel.active = true;
	}	
	// Update is called once per frame
	void Update () {
		bool allcheck = true;
		for (int i = 0; allcheck && i < ballcheck.Length; i++) {
			allcheck &= ballcheck [i];
		}
		if (allcheck == true) {
			resetBall ();
			//Model.active = true;
			exempleModel.active = false;	
			BluePlant.SendMessage("Change");
			BlueRed.SendMessage("Change");

			lookforscript.GetComponent<StoryScript> ().isProgressCheck = true;
		
		}
	}
	void checkIDBall(int id)
	{
		ballcheck[id] = true;
	}

	void clearballs()
	{
		for (int i = 0; i < ballcheck.Length; i++) {
			ballcheck[i] = false;
		}



	}


	public void resetBall()
	{	 Model.active = false;
		 exempleModel.active = true;	
		
		for (int i = 0; i < ballcheck.Length; i++) {
			ballcheck [i] =false;
		}

	}







}
