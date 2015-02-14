using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vie : MonoBehaviour {

	public int vieDeDepart = 100;
	public int viee;
	public float energieDeDepart = 100;
	public float energie;
	public Slider sliderDeVie;
	public Slider sliderDenergie;
	public Image degats;
	public Text mort;
	public Color flashColor = new Color (1f, 0f, 0f, 0.1f);


	float flashspeed =5f;
	DeplacementPersonnage mouvement;
	bool damaged;
	bool isDead;


	// Use this for initialization
	void Start () {
		mort.enabled = false;
		viee = vieDeDepart;
		energie = energieDeDepart;
		mouvement = GetComponent<DeplacementPersonnage> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (damaged)
		{
			degats.color = flashColor;
		}

		else
		{
			degats.color = Color.Lerp (degats.color, Color.clear, flashspeed * Time.deltaTime);
		}

		damaged = false;
		energ ();
	}

	public void TakeDamage (int amount)
	{
		damaged = true;

		viee -= amount;
		sliderDeVie.value = viee;

		if (viee <= 0f && !isDead)
			Death ();
	}

	public void energ ()
	{
		sliderDenergie.value = energie;
		if (mouvement.run && energie >= 0) {
						energie -= 0.4f;

				}
		else {
			if (energie <= energieDeDepart)
				energie += 0.2f;
				}

	}

	void Death ()
	{
		isDead = true;
		mouvement.enabled = false;
		mort.enabled = true;

	}
	
	
}


