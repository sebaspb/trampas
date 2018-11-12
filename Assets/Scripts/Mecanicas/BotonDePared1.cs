using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonDePared1 : MonoBehaviour {

	/// <summary>
	/// 
	/// </summary>
	bool inTrigger;
	
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(Input.GetKeyDown(KeyCode.E) && inTrigger)
		{

			Debug.Log("Botón presionado");

		}
		
	}

	private void OnTriggerEnter(Collider other)
	{

		if(other.CompareTag("Player"))
		{

			
			inTrigger = true;
			Debug.Log("Ha entrado al trigger");

		}
		
	}

	private void OnTriggerExit(Collider other)
	{

		if(other.CompareTag("Player"))
		{

			inTrigger = false;

		}
		
	}
}
