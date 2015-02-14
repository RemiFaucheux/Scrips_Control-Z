using UnityEngine;
using System.Collections;

public class Clavier : MonoBehaviour {

	public int Degats = 50;
	
	VieEpita vieEnnemiEpita;
	
	VieSupBio vieEnnemiSupBio;
	Animator anim;
	public bool Attaking;
	public bool EpitaOnRange;
	bool SupBioOnRange;


	void Start (){
		vieEnnemiEpita = GetComponent<VieEpita> ();
		vieEnnemiSupBio = GetComponent<VieSupBio> ();
		anim = GetComponent <Animator> ();
	}

	void Update (){
		if (Input.GetKey (KeyCode.Mouse0))
			Attaking = true;
		else
			Attaking = false;

		anim.SetBool ("Attaking", Attaking);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "EnnemiEpita") {
			vieEnnemiEpita = other.gameObject.GetComponent<VieEpita> ();
			if(Attaking){
			vieEnnemiEpita.vie -= Degats;
			Score.score += 50;

			}
		}
		
		if (other.tag == "EnnemiSupBio") {
			vieEnnemiSupBio = other.gameObject.GetComponent<VieSupBio> ();
			if(Attaking){
			vieEnnemiSupBio.viesupbio -= Degats;

			Score.score += 50;
				
			}
		}
		
	}

}
