using UnityEngine;
using System.Collections;

public class StoryScript : MonoBehaviour {


	public int sceneCountstate;
	public GameObject Monk;
	// Use this for initialization
	public bool sceneIsStarted;
	public bool sceneIsProgress;
	public bool SceneIsFinshed;


	public bool isProgressCheck;
	public string isPorgressString;

	public string WaitLookObjectName;
	public bool WaitLookObject;



	// scripts
	public LookAtMonk lookInteraction;
	public FmodAudioScript setSoundtrack;


	public GameObject redMonkAudio;
	public GameObject blueMonkAudio;



	//boat move script
	public GameObject moveBoatAniamtion;

	public GameObject MoveRedMonk;
	public GameObject MoveBlueMonk;
	//public GameObject AnimationMonk;


	public GameObject RedYingYang;

	public GameObject BlueYingYang;

	public FadeScript Callfade;


	public GameObject redPartical; 
	public GameObject bluePartical; 


	public GameObject showRedPlant;
	public GameObject showBluePlant;


	public GameObject redSucces;
	public GameObject blueSucces;


//	public GameObject redLight;
	//public GameObject blueLight;
	//public GameObject finalLight;

	void Start () {


		//finalLight.SetActive (false);
		redPartical.SetActive (false);
		bluePartical.SetActive (false);


		sceneCountstate = 0;
		lookInteraction = GetComponent<LookAtMonk> ();
		setSoundtrack = GetComponent<FmodAudioScript> ();
		Callfade = GetComponent<FadeScript> ();

		RedYingYang.SetActive (false);
		//monkAudio.GetComponent<MonkAudioScript> ();
		Callfade.fadeOut();
		sceneIsStarted = true;
		sceneIsProgress = false;
		SceneIsFinshed = false;

//		RenderSettings.fog = true;
	//	RenderSettings.fogDensity = 1.0f;

		MoveRedMonk.SetActive (false);
		MoveBlueMonk.SetActive (false);
	
		//state = 0;	nextStep ();
	}
	void Update () {
		if (sceneIsStarted){
			sceneInformationValue ();
			sceneIsStarted = false;
			sceneIsProgress = true;
		}
		if(sceneIsProgress){
			if (isProgressCheck == true){// if coroutine is finshed or the a procces is done
				isProgressCheck = false;
				SceneIsFinshed = true;
				//textDebug = "PROGRESS COMPLETE";
			}// wait for look moment
		}
		if (SceneIsFinshed) {
			SceneIsFinshed = false;
			sceneCountstate++; 
			sceneIsStarted = true;
		
		}

	
	
	}
	// if scene is in progress
	IEnumerator sceneWaitTime(int timeWait){
		Debug.Log ("about to yield return WaitForSeconds(" + timeWait.ToString() + ")"); 
		yield return new WaitForSeconds(timeWait);
		Debug.Log ("Just waited another second");
		isProgressCheck = true;
		yield break;
	
	}
	void waitForAnimationSet(string monkName){

		WaitLookObject = true;
		WaitLookObjectName = monkName;
		
	}

	void OnGUI(){
		//if (checkDebug) {
		//	GUI.Box (new Rect (0, 0, Screen.width, 90), DebugScene ());
		//}
	}

	string DebugScene(){
	return "  n\" scene nummer " + sceneCountstate.ToString ();
	}




    /*IEnumerator fogIncrease(){
     float count = 0.0f;
     RenderSettings.fog = true;
     RenderSettings.fogDensity = count;
     while (true) {
         yield return new WaitForSeconds (0.125f);
         count += 0.05f;
         RenderSettings.fogDensity = count;
         if (count > 1.0f) {
                 break;
             }
     }

 }   */
    /*
    IEnumerator fogDecrease(){
		float count = 1.0f;
		RenderSettings.fog = true;
		RenderSettings.fogDensity = count;
		while (true) {
			yield return new WaitForSeconds (0.1125f);
			count -= 0.05f;
			RenderSettings.fogDensity = count;
			if (count < 0.00f) {
				RenderSettings.fog = false;
				break;
			}
		}    
      }
 */

    public void sceneInformationValue(){
	
		Debug.Log ("sceneCountstate " + sceneCountstate.ToString ());
		// PRE Chapter 1
		if (sceneCountstate == 0) { 
			Callfade.fadeIn();
			MoveRedMonk.SetActive (true);
			StartCoroutine(sceneWaitTime(2));
			BlueYingYang.SetActive (false);
			//showRedPlant.GetComponent<Renderer> ().enabled = false;
			//showBluePlant.GetComponent<Renderer> ().enabled = false;

			//showBluePlant.GetComponent<render
			//showBluePlant.SetActive(true);
			//showRedPlant.SetActive (true);
			//redLight.SetActive(true);
		
		}
		// Chapter 1
		if (sceneCountstate == 1) { // i seek your aid
			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (0);
			StartCoroutine(sceneWaitTime(3));
			}
		if (sceneCountstate == 2) {// scene wait 3 seconds
			StartCoroutine(sceneWaitTime(3));
		}
		if (sceneCountstate == 3) {
			//StartCoroutine (fogDecrease ());
			//MoveRedMonk.GetComponent<MoveAnimation> ().monkMove ();
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (0);
			StartCoroutine(sceneWaitTime(3));		
		}
		if (sceneCountstate == 4) {	// scene wait 3 seconds	
			StartCoroutine(sceneWaitTime(3));		
		}
		if (sceneCountstate == 5) {	// scene wait 3 seconds	
			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (1);
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (4);
			StartCoroutine(sceneWaitTime(6));		
		}
		if (sceneCountstate == 6) {//
		//	MoveRedMonk.GetComponent<MoveAnimation> ().givingFlower();
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (5);

			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 7) {//
			//showRedPlant.GetComponent<Renderer> ().enabled = true;
		//	showBluePlant.GetComponent<Renderer> ().enabled = true;
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 8) {// SCENE WAIT FOR INTERACTION
            //RedYingYang.SetActive (true); // maby give a control a viberation
            StartCoroutine(sceneWaitTime(6));
        }
		if (sceneCountstate == 9) {
			redSucces.SetActive (true);
			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (2);
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (0);
			StartCoroutine(sceneWaitTime(6));
			redPartical.SetActive (true);
		}
		if (sceneCountstate == 10) {
			redSucces.SetActive (false);
			redPartical.SetActive (false);
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (5);
		//	MoveRedMonk.GetComponent<MoveAnimation> ().givingFlowerSecond();
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 11) {
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (0);
			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (3);
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 12) {// PRE Chapter 2
			Callfade.fadeOut();
			//showRedPlant.SetActive (false);

		//	redLight.SetActive(false);
			MoveRedMonk.SetActive (false);
			MoveBlueMonk.SetActive (true);
			StartCoroutine(sceneWaitTime(6));
		//	blueLight.SetActive (true);
		}
		if (sceneCountstate == 13) {// Chapter 2
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (0);
			StartCoroutine(sceneWaitTime(6));
		}			
		if (sceneCountstate == 14) {
			Callfade.fadeIn();
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 15) {
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (4);
			blueMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (1);
			StartCoroutine(sceneWaitTime(6));
		}	
	  	if (sceneCountstate == 16) {
			
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (0);
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 17) {
			//showBluePlant.SetActive(true);
			//bluePartical.SetActive (true);
			StartCoroutine(sceneWaitTime(5));
		}
		if (sceneCountstate == 18) {
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (5);
			blueMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (2);
			StartCoroutine (sceneWaitTime (6));
		}
		if (sceneCountstate == 19) {
            StartCoroutine(sceneWaitTime(6));

            BlueYingYang.SetActive (true);
			bluePartical.SetActive (false);
		}
		if (sceneCountstate == 20) {
			blueSucces.SetActive (true);
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (0);
			StartCoroutine(sceneWaitTime(6));		
		}
		if (sceneCountstate == 21) {
			blueSucces.SetActive (false);
			blueMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (3);
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (5);
			Callfade.fadeOut();
			StartCoroutine(sceneWaitTime(6));
		}


		if (sceneCountstate == 22) {
			MoveRedMonk.SetActive (false);
			MoveBlueMonk.SetActive (true);
			StartCoroutine(sceneWaitTime(6));
			//showBluePlant.SetActive(false);
			//redLight.SetActive(true);
			//blueLight.SetActive (false);
		}


	//	MoveRedMonk.SetActive (true);


		// chapter 3
		if (sceneCountstate == 23) {
			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (4);
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 24) {
			Callfade.fadeIn();
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 25) { // pre chapter
			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (5);
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 26) {
			
			StartCoroutine(sceneWaitTime(6));
			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (6);
		}		 
	
		if (sceneCountstate == 27) {		
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (5);
		//	MoveRedMonk.GetComponent<MoveAnimation> ().givingFlower();
			//showRedPlant.SetActive(true);
			StartCoroutine(sceneWaitTime(6));
		}
		if (sceneCountstate == 28) {
			//	fade in 
			Callfade.fadeIn();
			StartCoroutine(sceneWaitTime(6));
		//	showRedPlant.SetActive(false);
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (0);
			//redLight.SetActive (false);
		//	blueLight.SetActive (true);
		}



		/// chapter 4
		/// change scene light

	///

		if (sceneCountstate == 29) {
			MoveRedMonk.SetActive (true);
			MoveBlueMonk.SetActive (false);
			StartCoroutine(sceneWaitTime(6));
		}

		if (sceneCountstate == 30) {
			StartCoroutine(sceneWaitTime(6));
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (0);
			blueMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (4);
			Callfade.fadeOut();
		}



		if (sceneCountstate == 31) {
            Callfade.fadeIn();
            blueMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (5);
	//		showBluePlant.SetActive (true);
			StartCoroutine(sceneWaitTime(6));
		}
			
		if (sceneCountstate == 32) {

			//  we have start all over
			blueMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (6);
			StartCoroutine(sceneWaitTime(6));
		}

		if (sceneCountstate == 33) {
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (5);
			//MoveBlueMonk.GetComponent<MoveAnimation> ().givingFlower();
			StartCoroutine(sceneWaitTime(6));

		}

		if (sceneCountstate == 34) {
		
			StartCoroutine(sceneWaitTime(6));
		}

		if (sceneCountstate == 35) {
			MoveRedMonk.SetActive (true);
			MoveBlueMonk.SetActive (true);
            StartCoroutine(sceneWaitTime(6));
        }



		if (sceneCountstate == 36) {
			Callfade.fadeOut();
			StartCoroutine(sceneWaitTime(6));
		}


		// chapter 5 
		// show both monks..


		if (sceneCountstate == 37) { //  as do i 
			MoveRedMonk.GetComponent<monkIdle>().changeMovement (0);
			MoveBlueMonk.GetComponent<monkIdle>().changeMovement (0);

			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (7);
			StartCoroutine(sceneWaitTime(6));
           
            //finalLight.SetActive (true);
        }
		if (sceneCountstate == 38) { //  you are holding a plant with life
			blueMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (7);
			StartCoroutine(sceneWaitTime(6));
		
		}

		if (sceneCountstate == 39) { //  you are holding a plant with life
			redMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (8);
			StartCoroutine(sceneWaitTime(6));

		}

		if (sceneCountstate == 40) { //  you are holding a plant with life
			blueMonkAudio.GetComponent<MonkAudioScript> ().MonkSpeak (8);
			Callfade.fadeOut();

		}
		if (sceneCountstate == 41) { //  orange company
			

		}



	}






}
