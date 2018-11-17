using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampilla1: MonoBehaviour
{

	/// <summary>
	/// Cuando el jugador pase por el trigger se ejecuta la animación abrir e inmediatamente
	/// después la animación cerrar.
	/// </summary>
	
	bool EstaAbierta = false;

	float vida = 500f;

	float vidaTotal;

	public GameObject FBX;

	public GameObject Trigger;

	public float tiempo;

	public float Daño;

	Animation Animacion;
	void Start () 
	{

		Animacion = FBX.GetComponent<Animation>();
		

	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Trigger.GetComponent<RevisionTrigger>().EstaEnTrigger)
		{
			if(!EstaAbierta)
			{

				Animacion.Play("AbrirTrampilla");
				vida -= Daño;
				Debug.Log("Vida" + vida);
				EstaAbierta = true;
				StartCoroutine(CerrarTrampa(tiempo));

			}

			if(vida <= 0)
			{

				Destroy(GameObject.FindWithTag("Player"));

			}

		}
		
		
	}

	IEnumerator CerrarTrampa(float time)
	{

		yield return new WaitForSeconds(time);
		Animacion.Play("CerrarTrampilla");
		EstaAbierta = false;

	}
}
