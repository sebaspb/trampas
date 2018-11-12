using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RevisionTrigger : MonoBehaviour 
{

	public bool EstaEnTrigger = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("Player"))
		{

			EstaEnTrigger = true;

		}

	}

	private void OnTriggerExit(Collider other)
	{
		
		if(other.CompareTag("Player"))
		{

			EstaEnTrigger = false;

		}


	}
}

