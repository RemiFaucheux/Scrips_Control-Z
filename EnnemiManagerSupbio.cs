using UnityEngine;

public class EnnemiManagerSupbio : MonoBehaviour
{
	public Vie playerHealth;       
	public GameObject enemy;                
	public float spawnTime = 3f;            
	public Transform[] spawnPoints; 
	float timer1 ;
	float timer2 ;
	float timer3 ;
	float timer4 ;
	
	
	void Start ()
	{
		timer1 = 0f;
		timer2 = 0.5f;
		timer3 = 1f;
		timer4 = 1.5f;
		
	}
	void Update (){
		timer1 += Time.deltaTime;
		timer2 += Time.deltaTime;
		timer3 += Time.deltaTime;
		timer4 += Time.deltaTime;
	}
	
	public void Spawn (int x)
	{
		int a = 0;
		if(playerHealth.viee <= 0f)
		{
			// ... exit the function.
			return;
		}
		while ( (a < x)){
			if (timer1 > 10){
				// Find a random index between zero and one less than the number of spawn points.
				int spawnPointIndex = Random.Range (0, spawnPoints.Length);
				
				// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
				Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
				timer1 = 0f;
			}
			if (timer2 > 10){
				// Find a random index between zero and one less than the number of spawn points.
				int spawnPointIndex = Random.Range (0, spawnPoints.Length);
				
				// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
				Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
				timer2 = 0f;
			}
			if (timer3 > 10){
				// Find a random index between zero and one less than the number of spawn points.
				int spawnPointIndex = Random.Range (0, spawnPoints.Length);
				
				// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
				Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
				timer3 = 0f;
			}
			if (timer4 > 10){
				// Find a random index between zero and one less than the number of spawn points.
				int spawnPointIndex = Random.Range (0, spawnPoints.Length);
				
				// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
				Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
				timer4 = 0f;
			}
		}
	}
}
