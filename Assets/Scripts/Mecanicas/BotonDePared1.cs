using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class BotonDePared1 : MonoBehaviour {

	/// <summary>
	/// 
	/// </summary>
	bool inTrigger;
    public GameObject FBX;
    Animation  Animator;
  
	
	void Start () 
	{
        Animator = FBX.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(Input.GetKeyDown(KeyCode.E) && inTrigger)
		{

            if (!Animator.IsPlaying("Presionar Boton Pared")) { 

			Debug.Log("Botón presionado");

            Animator.Play("Presionar Boton Pared");
            

            }

            else
            {
                Debug.Log("Boton en uso");
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
