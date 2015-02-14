using UnityEngine;
using System.Collections;

public class SwapArmes : MonoBehaviour {

	public GameObject clavier;
	public GameObject Ram;
	MeshRenderer RamMesh;
	InstRam ramClass;
	MeshRenderer clavierMesh;
	Clavier clavierClass;

	public bool ClavierEquip = true;

	void Start () {
		clavierMesh = clavier.GetComponent<MeshRenderer> ();
		clavierClass = clavier.GetComponent<Clavier> ();
		RamMesh = Ram.GetComponent<MeshRenderer> ();
		ramClass = Ram.GetComponent<InstRam> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F))
						ClavierEquip = !ClavierEquip;

		EquipeClavier ();

	}

	void EquipeClavier () {
		if (ClavierEquip)
		{
			clavierMesh.enabled = true;
			clavierClass.enabled = true;
			RamMesh.enabled = false;
			ramClass.enabled = false;
		}
		else{
			clavierMesh.enabled = false;
		clavierClass.enabled = false;
		RamMesh.enabled = true;
		ramClass.enabled = true;
		}
	}
}
