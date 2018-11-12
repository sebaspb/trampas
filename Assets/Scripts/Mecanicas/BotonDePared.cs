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

	public GameObject Trigger;

	Animation Animacion;

		
	void Start () 
	{

		Animacion = FBX.GetComponent<Animation>();
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(Input.GetKeyDown(KeyCode.E) && Trigger.GetComponent<RevisionTrigger>().EstaEnTrigger)
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

}
