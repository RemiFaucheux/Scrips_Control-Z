using UnityEngine;
using System.Collections;

public class EpitaAttaque : MonoBehaviour {

	public float TimeAttacks = 1.5f;
	public static int attackDamage;

	GameObject player;
	Vie life;
	bool range;
	float timer;
	// Use this for initialization
	void Start () {
		if (VaguesScript.zombieKilled < 120)
			attackDamage = 10;
		else if (VaguesScript.zombieKilled >= 120)
			attackDamage = 15;
		player = GameObject.FindGameObjectWithTag ("Player");
		life = player.GetComponent <Vie> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer >= TimeAttacks && range)
						attack ();

	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player)
						range = true;

		}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject == player)
						range = false;

	}
	void attack()
	{
		timer = 0f;
		if (life.viee > 0)
						life.TakeDamage (attackDamage);
		}
}
