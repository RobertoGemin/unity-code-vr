using UnityEngine;
using System.Collections;


public class animatorController : MonoBehaviour {

	public Animator anim;
	public bool jumpHash = true;


	public GameObject brown;


	public Color colorStartBrown;
	public Color colorEndBrown;

	//public Renderer rend;
	public float duration = 1;
	public float smoothness = 0.02f;



	public bool isPlantALive;

	//public Color newcolor;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		//green.GetComponent<Renderer> ().material.color = colorStartGreen;
		brown.GetComponent<Renderer> ().material.color = colorStartBrown;

		if (isPlantALive) {
		
			anim.SetBool ("live", true);
			StartCoroutine("ChangeColorToLive");
		} 
		else {
			anim.SetBool ("live", false);
			StartCoroutine("ChangeColorToDeath");
		}

	

		}

	IEnumerator ChangeColorToLive(){

		float progress = 0;
		float increment = smoothness / duration;

		while (progress < 1) {

			//green.GetComponent<Renderer> ().material.color = Color.Lerp (colorStartGreen, colorEndGreen,progress);
			brown.GetComponent<Renderer> ().material.color = Color.Lerp (colorStartBrown, colorEndBrown,progress);

			progress += increment;
			yield return new WaitForSeconds (smoothness);
		}
		return true;
	}


	IEnumerator ChangeColorToDeath()
	{

		float progress = 0;
		float increment = smoothness / duration;

		while (progress < 1) {
			//green.GetComponent<Renderer> ().material.color = Color.Lerp ( colorEndGreen,colorStartGreen,progress);
			brown.GetComponent<Renderer> ().material.color = Color.Lerp ( colorEndBrown,colorStartBrown,progress);
			progress += increment;
			yield return new WaitForSeconds (smoothness);
		}
		return true;
	}






	IEnumerator fade()
	{

		float progress = 0;
		float increment = smoothness / duration;

		while (progress < 1) {

			colorStartBrown.a = Mathf.Lerp(0f,255f, progress);
			colorEndBrown.a = Mathf.Lerp(0f,255f, progress);
			//green.GetComponent<Renderer> ().material.color = Color.Lerp ( colorEndGreen,colorStartGreen,progress);
			//brown.GetComponent<Renderer> ().material.color.a = Color.Lerp ( colorEndBrown.a,newcolor.a,progress);
			//brown.GetComponent<Renderer> ().material.color = colorStartBrown;
			progress += increment;
			yield return new WaitForSeconds (smoothness);
		}
		return true;
	}


	IEnumerator fadeOut()
	{

		float progress = 0;
		float increment = smoothness / duration;

		while (progress < 1) {

			colorStartBrown.a = Mathf.Lerp(255,0, progress);
			colorEndBrown.a = Mathf.Lerp(255,0, progress);
		//	brown.GetComponent<Renderer> ().material.color = colorStartBrown;
			//green.GetComponent<Renderer> ().material.color = Color.Lerp ( colorEndGreen,colorStartGreen,progress);
			//brown.GetComponent<Renderer> ().material.color.a = Color.Lerp ( colorEndBrown.a,newcolor.a,progress);
			progress += increment;
			yield return new WaitForSeconds (smoothness);
		}
		return true;
	}





	public void Change()
	{
		if (isPlantALive == true) {
			anim.SetBool ("live", false);
			StartCoroutine ("ChangeColorToDeath");
			isPlantALive = false;
		} else {
			anim.SetBool ("live", true);
			StartCoroutine("ChangeColorToLive");
			isPlantALive = true;

		}
	}



	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			
			Debug.Log ("fade");
	//	StartCoroutine ("fade");

		}
		if(Input.GetKeyDown(KeyCode.LeftShift)){


			Debug.Log ("fadeOut");
		//StartCoroutine ("fadeOut");

		}

			
	}




}
