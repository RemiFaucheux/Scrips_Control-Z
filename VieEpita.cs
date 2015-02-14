using UnityEngine;
using System.Collections;

public class VieEpita : MonoBehaviour {

	public static int viemax ;
	public int vie;
	bool Mort;
	EpitaDeplacement deplacement;



	void Start () 
	{
		if (VaguesScript.zombieKilled < 120)
						viemax = 100;
				else if (VaguesScript.zombieKilled >= 120)
						viemax = 150;
		vie = viemax;
		deplacement = GetComponent<EpitaDeplacement> ();

	}

	void Update () 
	{
		if (vie <= 0f && !Mort)
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
