using UnityEngine;
using System.Collections;

public class MonkAudioScript : MonoBehaviour {




	[FMODUnity.EventRef]
	public string[] speakArr;
	FMOD.Studio.EventInstance musicEv;
	FMOD.Studio.ParameterInstance musicParam;

	public void MonkSpeak(int lineText){
		if (speakArr [lineText] != null) {
			musicEv = FMODUnity.RuntimeManager.CreateInstance (speakArr [lineText]);
			FMODUnity.RuntimeManager.PlayOneShot (speakArr [lineText]);
		}
	}
}
