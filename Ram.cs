using UnityEngine;
using System.Collections;

public class Ram : MonoBehaviour {

	public int Degats = 35;
	public GameObject barrette;
	VieEpita vieEnnemiEpita;
	public float VitesseRam = 50f;

	VieSupBio vieEnnemiSupBio;
	float timer = 1f;
	float timerExplo= 0f;
	public bool Explose;

	void Start () {
		DestructionAuto();
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timerExplo += Time.deltaTime;
		if ((timerExplo  >= 1f) && (timerExplo <= 1.02) && Explose){
			GameObject ramUp = (GameObject)Instantiate (barrette, gameObject.transform.position, gameObject.transform.rotation);
			ramUp.rigidbody.AddForce(gameObject.transform.forward*VitesseRam, ForceMode.Impulse);
			GameObject ramDown = (GameObject)Instantiate (barrette, gameObject.transform.position, gameObject.transform.rotation);
			ramDown.rigidbody.AddForce(gameObject.transform.forward*(-VitesseRam), ForceMode.Impulse);
			GameObject ramLeft = (GameObject)Instantiate (barrette, gameObject.transform.position, gameObject.transform.rotation);
			ramLeft.rigidbody.AddForce(gameObject.transform.right*(-VitesseRam), ForceMode.Impulse);
			GameObject ramRight = (GameObject)Instantiate (barrette, gameObject.transform.position, gameObject.transform.rotation);
			ramRight.rigidbody.AddForce(gameObject.transform.right*VitesseRam, ForceMode.Impulse);
			GameObject ramHaut = (GameObject)Instantiate (barrette, gameObject.transform.position, gameObject.transform.rotation);
			ramHaut.rigidbody.AddForce(gameObject.transform.up*VitesseRam, ForceMode.Impulse);
			GameObject ramBas = (GameObject)Instantiate (barrette, gameObject.transform.position, gameObject.transform.rotation);
			ramBas.rigidbody.AddForce(gameObject.transform.up*(-VitesseRam), ForceMode.Impulse);


		}
	
	}

	// Detction des ennemis
	 void OnTriggerEnter (Collider other)
	{
		if (other.tag == "EnnemiEpita") {
			vieEnnemiEpita = other.gameObject.GetComponent<VieEpita> ();
			if (timer >= 0.2f){
				vieEnnemiEpita.vie -= Degats;
				Score.score += 10;
				Destroy(gameObject);
				timer = 0f;
			}
				}

		if (other.tag == "EnnemiSupBio" && timer >= 0.1f) {
			vieEnnemiSupBio = other.gameObject.GetComponent<VieSupBio> ();
			if (timer >= 0.2f){
				vieEnnemiSupBio.viesupbio -= Degats;
				Destroy(gameObject);
				Score.score += 10;
				timer = 0f;
			}
				}

		}
		
	public void DestructionAuto()
	{
		Destroy (gameObject, 3f);
	}
}
