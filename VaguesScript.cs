using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class VaguesScript : MonoBehaviour {

	public static int zombieKilled = 0;
	public GameObject ennemiEpita;//ennemi que l'on veut instancier dans la methode spawnEpita
	public GameObject ennemiSupbio; //ennemi que l'on veut instancier dans la methode spawnSupbio
	public Transform[] spawnPoints;//tableau des points de spawn, il faut les ajouter via unity
	public Text msg; 
	public Text vagueText;
	public int noVague = 1;
	public static float timer = 0f;
	public bool nextwave;
	public bool isInterWave;
	public int spawnPointIndex;




	void Start () 
	{
		zombieKilled = 0;
		noVague = 1;
		nextwave = false;
		isInterWave = true;
	}
	

	void Update () 
	{
		spawnPointIndex = Random.Range (0, spawnPoints.Length);
		if (isInterWave) 
		{
			timer += Time.deltaTime; //Timer pour entre les vagues
		}
		msg.text = "Prochaine vague dans :  " + (45-timer) + " Press M pour passer"; //Message affiché entre les vagues
		vagueText.text = "Vague " + (noVague - 1); 
		//Permet de passer l'attente entre les vagues
		if (Input.GetKeyUp (KeyCode.M))
			timer = 45f;

		//Vague 1
		if (zombieKilled == 0 && noVague == 1 && timer > 10f) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(16));
			noVague += 1;

		}
		if (zombieKilled == 16) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 16 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 16 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;

		}

		//Vague 2
		if (zombieKilled == 16 && noVague == 2 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(20));
			noVague += 1;

		}
		if (zombieKilled == 36) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 36 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 36 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;

		}

		//Vague 3
		if (zombieKilled == 36 && noVague == 3 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(24));
			noVague += 1;

		}
		if (zombieKilled == 60) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 60 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 60 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;

		}
		//Vague 4
		if (zombieKilled == 60 && noVague == 4 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(28));
			noVague += 1;
		}
		if (zombieKilled == 88) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 88 && timer < 45f) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 88 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;

		}
		//Vague 5
		if (zombieKilled == 88 && noVague == 5 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(32));
			noVague += 1;

		}
		if (zombieKilled == 120) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 120 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 120 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;

		}
		//Vague 6
		if (zombieKilled == 120 && noVague == 6 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(16));
			noVague += 1;
			
		}
		if (zombieKilled == 136) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 136 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 136 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;
			
		}
		//Vague 7
		if (zombieKilled == 136 && noVague == 7 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(20));
			noVague += 1;
			
		}
		if (zombieKilled == 156) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 156 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 156 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;
			
		}
		//Vague 8
		if (zombieKilled == 156 && noVague == 8 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(24));
			noVague += 1;
			
		}
		if (zombieKilled == 180) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 180 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 180 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;
		}
		//Vague 9
		if (zombieKilled == 180 && noVague == 9 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(28));
			noVague += 1;
			
		}
		if (zombieKilled == 208) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 208 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 120 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;
			
		}
		//Vague 10
		if (zombieKilled == 208 && noVague == 10 && nextwave) 
		{
			isInterWave = false;
			nextwave = false;
			StartCoroutine (vague(32));
			noVague += 1;
			
		}
		if (zombieKilled == 240) 
		{
			isInterWave = true;
		}
		if (zombieKilled == 240 && timer < 45f ) 
		{
			msg.enabled = true;
		} 
		else if (zombieKilled == 240 && timer > 45f ) 
		{
			msg.enabled = false;
			nextwave = true;
			
		}
	}

	//Methode de spawn
	IEnumerator vague(int x)
	{
		int a = 0;
		while (a < x) 
		{
			Instantiate (ennemiSupbio, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			yield return new WaitForSeconds(1f);
			Instantiate (ennemiSupbio, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			yield return new WaitForSeconds(1f);
			Instantiate (ennemiEpita, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			yield return new WaitForSeconds(1f);
			Instantiate (ennemiEpita, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			a += 4;
			nextwave = false;
			yield return new WaitForSeconds(8f);
		}
	}
}
