using UnityEngine;
using System.Collections;

public class FmodAudioScript : MonoBehaviour {

	public string AudioPath = "event:/Soundtracks";
	FMOD.Studio.EventInstance Soundtracks;
	FMOD.Studio.ParameterInstance SoundtracksParam;


	[FMODUnity.EventRef]
	public string goodsound = "event:/Ping";
	FMOD.Studio.EventInstance createGood;




	void Start () {
		Soundtracks = FMODUnity.RuntimeManager.CreateInstance (AudioPath);
		Soundtracks.getParameter ("SkipRegion", out SoundtracksParam);


		FMOD.Studio.PLAYBACK_STATE play_state;
		Soundtracks.getPlaybackState (out play_state);
		if (play_state != FMOD.Studio.PLAYBACK_STATE.PLAYING){
			Soundtracks.start ();
			SoundtracksParam.setValue (0f);
		}
	}

	public void ChangeAtmospher (float Value){
		SoundtracksParam.setValue (Value);


	}

	public void audio(){

		createGood = FMODUnity.RuntimeManager.CreateInstance (goodsound);
		FMODUnity.RuntimeManager.PlayOneShot (goodsound);
	
	}



	// Update is called once per frame
	void Update () {
	
	}
}
