using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeletransportarObjeto : MonoBehaviour {

	/// <summary>
	/// Implementar código en un trigger
	/// </summary>

	public GameObject Jugador;
	
	public float posicionJugadorX;

	public float posicionJugadorY;

	public float posicionJugadorZ;

	
	
	void Start () 
	{

		
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	
		
	}

	
	void OnTriggerEnter(Collider other)
	{

		if(other.CompareTag("Player"))
		{

			Jugador.transform.localPosition = new Vector3(Jugador.transform.localPosition.x + posicionJugadorX, Jugador.transform.localPosition.y + posicionJugadorY, Jugador.transform.localPosition.z + posicionJugadorZ);

		}
		
	}


}
