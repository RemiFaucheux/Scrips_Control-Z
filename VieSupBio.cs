using UnityEngine;
using System.Collections;

public class VieSupBio : MonoBehaviour {
	
	public static int viemax ;
	public int viesupbio;
	bool Mort;
	SupBioDeplacement deplacement;


	void Start () 
	{
		if (VaguesScript.zombieKilled < 120)
			viemax = 100;
		else if (VaguesScript.zombieKilled >= 120)
			viemax = 150;
		viesupbio = viemax;
		deplacement = GetComponent<SupBioDeplacement> ();

	}

	void Update () 
	{
		if (viesupbio <= 0f && !Mort)
		{
			Death ();
		}
	}

	void Death()
	{
		Mort = true;
		deplacement.enabled = false;
		Destroy(gameObject, 0f);
		VaguesScript.zombieKilled += 1;
		VaguesScript.timer = 0f;
	}
}