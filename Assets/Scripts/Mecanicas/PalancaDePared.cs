﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

using UnityEditor;

public class PalancaDePared : MonoBehaviour {

	/// <summary>
	/// 
	/// </summary>
	bool inTrigger;

	public GameObject FBX;

	public GameObject Trigger;

	public GameObject nivel;

	public AnimationClip AnimacionAsignada;

    public bool SePuedeRepetir = false;

    string nombre;

    int layer;

	Animation AnimacionBoton;

    public AnimationClip[] ArrayAnimaciones;

    bool activada = false;

       

    void Start () 
	{
        AnimacionBoton = FBX.GetComponent<Animation>();

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

		if(Input.GetKeyDown(KeyCode.E) && Trigger.GetComponent<RevisionTrigger>().EstaEnTrigger && activada==false)
		{
            if (!AnimacionBoton.IsPlaying("Accionar Boton"))
            {
                int control = 0;

                Debug.Log("Botón presionado");
                AnimacionBoton.Play("Accionar Boton");
                activada = true;
               
                ManagerNiverl3.Counter += 1;
                Debug.Log(ManagerNiverl3.Counter);
                
                

                if (AnimacionAsignada != null)
                {
                    if (!SePuedeRepetir && control==0)
                    {

                      
                            control = 1;
                            nivel.GetComponent<Animator>().Play(nombre, layer);
                       
                    }

                }
            }
             

            else
            {
               
                Debug.Log("Botón en uso");

            }
			

		}

		
	}

}
