using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class BotonDePared : MonoBehaviour {

	/// <summary>
	/// 
	/// </summary>
	bool inTrigger;

	public GameObject FBX;

	Animation Animacion;

		
	void Start () 
	{

		Animacion = FBX.GetComponent<Animation>();
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(Input.GetKeyDown(KeyCode.E) && inTrigger)
		{
			if(!Animacion.IsPlaying("Accionar Boton"))
			{

				Debug.Log("Botón presionado");
				Animacion.Play("Accionar Boton");

			}
			
			else
			{

				Debug.Log("Botón en uso");

			}
			

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
