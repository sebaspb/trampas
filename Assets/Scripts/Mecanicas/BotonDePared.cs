using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonDePared : MonoBehaviour {

	/// <summary>
	/// Este código se pone en el botón de pared, cuando el jugador esté cerca, 
	/// que se imprima en consola se puede usar, si se puede usar el botón y oprime E entonces 
	/// imprime el botón ha sido presionado.
	/// </summary>
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

			Debug.Log("El botón se puede usar");

		}
		
	}
}
