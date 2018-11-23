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


    public AnimationClip[] ArrayAnimaciones;
    public AnimationClip AnimacionAsignada;
    string nombre;
    int layer;
    public bool SePuedeRepetir = false;

    void Start ()
	{
        

        for (int i = 0; i < ArrayAnimaciones.Length; i++)
        {
            if (AnimacionAsignada == ArrayAnimaciones[i])
            {
                nombre = AnimacionAsignada.name;
                layer = i;
            }


        }

    }
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	private void OnTriggerEnter(Collider other)
	{

		if(other.CompareTag("Player"))
		{
            int control = 0;

            if (AnimacionAsignada != null)
            {
                if (!SePuedeRepetir && control == 0)
                {

                    control = 1;
                    nivel.GetComponent<Animator>().Play(nombre, layer);
                    Destroy(gameObject);
                }
            }
        }
		
	}
}
