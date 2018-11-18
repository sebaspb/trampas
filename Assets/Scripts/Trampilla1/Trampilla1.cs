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

	public float tiempoDaño;

	public float Daño;


    public bool tienesonido = false;

   

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
				StartCoroutine(DañoTrampa(tiempoDaño));
				EstaAbierta = true;
<<<<<<< HEAD
                if (tienesonido) {
                this.GetComponent<AudioSource>().Play();
                }
                StartCoroutine(CerrarTrampa(tiempo));
                
=======
				StartCoroutine(CerrarTrampa(tiempo));
				
>>>>>>> 3f286cea45e51fdf80676bbe5123adc974fd7b2b
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
        if (tienesonido)
        {
            this.GetComponent<AudioSource>().Play();
        }
        Animacion.Play("CerrarTrampilla");
    
        EstaAbierta = false;

	}

	IEnumerator DañoTrampa(float time)
	{

		yield return new WaitForSeconds(time);
		if(Trigger.GetComponent<RevisionTrigger>().EstaEnTrigger)
		{

			vida -= Daño;
			Debug.Log("Vida" + vida);
		
		}

	}
}
