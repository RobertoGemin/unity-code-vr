using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
//using PDollarGestureRecognizer;

public class WandController : MonoBehaviour {
	//private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
	//private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
//	private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
	//private SteamVR_TrackedObject trackedObj;
	private GameObject pickup;
	// Use this for initialization


	//drawing
	public Transform gestureOnScreenPrefab;
//	private List<Gesture> trainingSet = new List<Gesture>();
//	private List<Point> points = new List<Point>();
	private int strokeId = -1;
	private Vector3 virtualKeyPosition = Vector2.zero;

	private RuntimePlatform platform;
	private int vertexCount = 0;

	private List<LineRenderer> gestureLinesRenderer = new List<LineRenderer>();
	private LineRenderer currentGestureLineRenderer;

	//GUI
	private string message;
	private bool recognized;
	private string newGestureName = "";

	//Audio
	[FMODUnity.EventRef]
	public string AudioPath = "event:/Interaction";
	FMOD.Studio.EventInstance musicEv;
	FMOD.Studio.ParameterInstance musicParam;


	void Start () {

		//audio

		musicEv = FMODUnity.RuntimeManager.CreateInstance (AudioPath);
	
		musicEv.getParameter ("Trigger", out musicParam);

		//	musicEv.getParameter ("pos", out musicParam);
	//	rollingEv.getParameter("")

	//	trackedObj = GetComponent<SteamVR_TrackedObject>();



		//Load pre-made gestures
	}

	// Update is called once per frame
	void Update () {
        /*
        if (controller == null) {
			Debug.Log("Controller not initialized");
			return;
		}


		if (controller.GetPressDown(triggerButton)) {


			++strokeId;

			Transform tmpGesture = Instantiate(gestureOnScreenPrefab, transform.position, transform.rotation) as Transform;
			currentGestureLineRenderer = tmpGesture.GetComponent<LineRenderer>();

			gestureLinesRenderer.Add(currentGestureLineRenderer);

			vertexCount = 0;


			FMOD.Studio.PLAYBACK_STATE play_state;
			musicEv.getPlaybackState (out play_state);
			if (play_state != FMOD.Studio.PLAYBACK_STATE.PLAYING)
			{
				musicEv.start ();
				musicParam.setValue (0f);
			}
	
		}
			
		if (controller.GetPress(triggerButton)) {


			//SteamVR_Controller.Input([the index of the controller you want to vibrate]).TriggerHapticPulse([length in microseconds as ushort]);
		//	SteamVR_Controller.Input[steamVR_Controller.Input((int)trackedObj.index)].TriggerHapticPulse[5,5];
			controller.TriggerHapticPulse(500);
			musicParam.setValue (1f);
			currentGestureLineRenderer.SetVertexCount(++vertexCount);
			currentGestureLineRenderer.SetPosition(vertexCount - 1, new Vector3(this.transform.position.x, 	this.transform.position.y, 	this.transform.position.z));
		}



		if (controller.GetPressUp(triggerButton)) {

			foreach (LineRenderer lineRenderer in gestureLinesRenderer) {
				lineRenderer.SetVertexCount(0);
				Destroy(lineRenderer.gameObject);
			}

			gestureLinesRenderer.Clear();

			musicParam.setValue (0f);
			musicEv.stop (FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
			}

		if (controller.GetPressDown(gripButton)) {
			
			foreach (LineRenderer lineRenderer in gestureLinesRenderer) {
					lineRenderer.SetVertexCount(0);
					Destroy(lineRenderer.gameObject);
					}

				gestureLinesRenderer.Clear();
			//	pickup.transform.parent = this.transform;
			//	pickup.GetComponent<Rigidbody>().useGravity = false;
		}

		if (controller.GetPressDown(gripButton) && pickup != null) {
			Debug.Log("presssss");
		//	pickup.transform.parent = this.transform;
		//	pickup.GetComponent<Rigidbody>().useGravity = false;
		}
		if (controller.GetPressUp(gripButton) && pickup != null) {
			Debug.Log("presssss down");
		//	pickup.transform.parent = null;
		//	pickup.GetComponent<Rigidbody>().useGravity = true;
		}
	*/
    }

	private void OnTriggerEnter(Collider collider) {
		//pickup = collider.gameObject;
	}

	private void OnTriggerExit(Collider collider) {
		//pickup = null;
	}
}
