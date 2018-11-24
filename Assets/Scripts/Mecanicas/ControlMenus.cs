using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ARFC;
using UnityEngine.UI;




public class ControlMenus : MonoBehaviour
{

	public GameObject PausaMenu;

	public Button Continuar;


    

    void Start ()
	{


    }
	
	// Update is called once per frame
	void Update () 
	{

		Pausa();

	}

	public void CargarScena(int i)
	{

		SceneManager.LoadScene(i);

	}

   

	public void ActivarCanvas(GameObject canvasActivado)
	{
		canvasActivado.SetActive(true);
	}

	public void DesactivarCanvas(GameObject canvasDesactivado)
	{
		canvasDesactivado.SetActive(false);
	}

	public void Pausa()
    {	
		if (Time.timeScale == 1.0f && Input.GetKeyDown(KeyCode.P))
        {
			PausaMenu.SetActive(true);
            //         Time.timeScale = 0.0f;



            GameObject.FindWithTag("Player").GetComponent<FPController>().Constraints.Move = false;
    




    }
    
	}

	public void QuitarPausar()
	{

		Time.timeScale = 1.0f;
		//GameObject.FindWithTag("Player").GetComponent<FPController>().enabled = true;

	}

	public void QuitarJuego()
	{
		Application.Quit();
	}

}