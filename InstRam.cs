using UnityEngine;
using System.Collections;

public class InstRam : MonoBehaviour {

	public float TimeAttacks = 0.5f;
	public GameObject BarrettedeRam;
	public float VitesseRam = 100f;
	float timer = 1;

	void Start () {

	}
	

	void Update () {

		timer += Time.deltaTime;

		//Creer une barrette de ram et la lancer 
		if (Input.GetKeyDown (KeyCode.Mouse0) && timer >= TimeAttacks) {
			Camera cam = Camera.main;
			GameObject theRAM = (GameObject)Instantiate (BarrettedeRam, cam.transform.position, cam.transform.rotation);
			theRAM.rigidbody.AddForce(cam.transform.forward*VitesseRam, ForceMode.Impulse);
			timer = 0f;
				}
	}

}
