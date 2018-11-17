using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{

	public float fuerza;

	private void OnCollisionEnter(Collision c)
	{

		if(c.transform.tag == "Player")
		{

			print("Algo");
			Vector3 dir = c.contacts[0].point - c.transform.position;

			dir = -dir.normalized;

			GetComponent<Rigidbody>().AddForce(dir*fuerza);

		}
		
	}

}
