using UnityEngine;
 
public class FadeScript : MonoBehaviour
{   
	
	public float fadeSpeed = 0.5f;
	public Texture fadeOutTexture;
	private float drawDepth = -1000.0f;
	private float alpha = 1.0f;
	private float fadeDir = -1;
	private Texture tempTexture;

	public void Start(){
		alpha = 1.0f;
		fadeIn ();
	}
	public void OnGUI(){
		alpha += fadeDir * fadeSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);
		Color temp = GUI.color;
		temp.a = alpha;
		GUI.color = temp;
		GUI.depth = (int)drawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
	}

	public void fadeIn(){
		fadeDir = -1;
	}

	public void fadeOut(){
		fadeDir = 1;
	}

}