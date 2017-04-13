using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class Demo : MonoBehaviour {

	public Transform gestureOnScreenPrefab;

//	private List<Gesture> trainingSet = new List<Gesture>();

//	private List<Point> points = new List<Point>();
	private int strokeId = -1;

	private Vector3 virtualKeyPosition = Vector2.zero;
	private Rect drawArea;

	private RuntimePlatform platform;
	private int vertexCount = 0;

	private List<LineRenderer> gestureLinesRenderer = new List<LineRenderer>();
	private LineRenderer currentGestureLineRenderer;

	//GUI
	private string message;
	private bool recognized;
	private string newGestureName = "";

	public GameObject ball;


	//Audio
	[FMODUnity.EventRef]
	public string AudioPath = "event:/Interaction";
	FMOD.Studio.EventInstance musicEv;
	FMOD.Studio.ParameterInstance musicParam;


	void Start () {


		musicEv = FMODUnity.RuntimeManager.CreateInstance (AudioPath);

	}
	void Update () {



		ball.transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10));


		if (platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer) {
			if (Input.touchCount > 0) {
				virtualKeyPosition = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);
			}
		} else {
			if (Input.GetMouseButton(0)) {
				virtualKeyPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
			}
		}

	
		// CHECK IS CLEAR
			if (Input.GetMouseButtonDown(0)) {

				if (recognized) {

					recognized = false;
					strokeId = -1;

	

					foreach (LineRenderer lineRenderer in gestureLinesRenderer) {

						lineRenderer.SetVertexCount(0);
						Destroy(lineRenderer.gameObject);
					}

					gestureLinesRenderer.Clear();
				}

				++strokeId;
				
				Transform tmpGesture = Instantiate(gestureOnScreenPrefab, transform.position, transform.rotation) as Transform;
				currentGestureLineRenderer = tmpGesture.GetComponent<LineRenderer>();
				
				gestureLinesRenderer.Add(currentGestureLineRenderer);

			FMOD.Studio.PLAYBACK_STATE play_state;
			musicEv.getPlaybackState (out play_state);
			if (play_state != FMOD.Studio.PLAYBACK_STATE.PLAYING)
			{
				musicEv.start ();
				//musicParam.setValue (0f);

			}



				
				vertexCount = 0;
			}
			
			if (Input.GetMouseButton(0)) {
			

				currentGestureLineRenderer.SetVertexCount(++vertexCount);
				currentGestureLineRenderer.SetPosition(vertexCount - 1, Camera.main.ScreenToWorldPoint(new Vector3(virtualKeyPosition.x, virtualKeyPosition.y, 10)));
			}







		if (Input.GetMouseButtonUp(0)) {


			musicEv.stop (FMOD.Studio.STOP_MODE.IMMEDIATE);


	
		}
	}


}
