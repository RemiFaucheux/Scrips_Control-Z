using UnityEngine;
using System.Collections;

public class DeplacementPersonnage : MonoBehaviour {

	public float movementspeed = 5.0f;
	public float mouseSensitivity = 2.0f;
	public float upDownRange = 60.0f;
	public float gravity = 20f;
	public float HauteurSaut = 10f;
	public bool run;

	Vie ene;
	CharacterController cc;
	float verticalRotation = 0f;
	float verticalVelocity = 0f;
	float bonusSpeed;

	void Start () {
		Screen.lockCursor = true;
		cc = GetComponent<CharacterController> ();
		ene = GetComponent<Vie> ();
	}

	void Update () {
		//Rotation
		float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
		transform.Rotate (0f, rotLeftRight, 0f);
		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0f, 0f);
		//Mouvement
		if (Input.GetKey (KeyCode.LeftShift) && ene.energie > 2f) 
		{
			bonusSpeed = 1.4f;
			run = true;
		} 
		else 
		{
			bonusSpeed = 1f;
			run = false;
		}
	
		float forwardSpeed = Input.GetAxis ("Vertical") * movementspeed*bonusSpeed;
		float sideSpeed = Input.GetAxis ("Horizontal") * movementspeed;
		verticalVelocity += Physics.gravity.y * Time.deltaTime;
		if (Input.GetButtonDown ("Jump") && cc.isGrounded) 
		{
			verticalVelocity = HauteurSaut;
		}
		Vector3 speed = new Vector3 (sideSpeed, verticalVelocity, forwardSpeed);
		speed = transform.rotation * speed;
		cc.Move (speed * Time.deltaTime);
	}
}
