using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimaciones : MonoBehaviour 
{

	/// <summary>
	/// En este debe haber un componente GameObject que se llama objeto, éste va a ser el principal del nivel, buscar 
	/// componente animation, debe haber una variable animationclip pública, cuando el jugador cruce el trigger 
	/// se active movimientopared.  
	/// </summary>
	
	public GameObject nivel;
	public string animacion;
	
	void Start ()
	{

		
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	private void OnTriggerEnter(Collider other)
	{

		if(other.CompareTag("Player"))
		{

			Debug.Log("Hola");
			nivel.GetComponent<Animation>().Play(animacion);

		}
		
	}
}
