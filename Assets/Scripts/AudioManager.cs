using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour {

 

   AudioSource audio;


    // Use this for initialization
    void Start () {
        audio=GetComponent<AudioSource>();


        AudioClip clip1 = Resources.Load<AudioClip>("Sonidos/Bienvenida");
        AudioClip clip2 = Resources.Load<AudioClip>("Sonidos/clase3 - 000");

        //audio.PlayOneShot(clip1);
      

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
