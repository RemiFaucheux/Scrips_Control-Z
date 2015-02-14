using UnityEngine;
using System.Collections;

public class SupBioDeplacement : MonoBehaviour {

	Transform player;
	Vie playerHealth;
	//EnemyHealth enemyHealth;
	public NavMeshAgent nav;
	
	
	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = player.GetComponent <Vie> ();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();
	}
	
	
	void Update ()
	{
		if (player.transform.position.y < 2.5f)
			nav.speed = 3f;
		else
			nav.speed = 2f;
		if(playerHealth.viee > 0)
		{
		nav.SetDestination (player.position);
		}
		else
		
		    nav.enabled = false;

	}
}
