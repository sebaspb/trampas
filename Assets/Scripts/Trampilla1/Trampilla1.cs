using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampilla1 : MonoBehaviour {

	/// <summary>
	/// Cuando el jugador pase por el trigger se ejecuta la animación abrir e inmediatamente
	/// después la animación cerrar.
	/// </summary>
	
	bool inTrigger;

	bool EstaAbierta = false;

	public GameObject FBX;

	Animation Animacion;
	void Start () 
	{

		Animacion = FBX.GetComponent<Animation>();
		

	}
	
	// Update is called once per frame
	void Update () 
	{

		if(inTrigger)
		{
			if(!EstaAbierta)
			{

				Animacion.Play("AbrirTrampilla1");
				EstaAbierta = true;
				StartCoroutine(CerrarTrampa(1f));

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

	IEnumerator CerrarTrampa(float time)
	{

		yield return new WaitForSeconds(time);
		Animacion.Play("CerrarTrampilla1");

	}
}
