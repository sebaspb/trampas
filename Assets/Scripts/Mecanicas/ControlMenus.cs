using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenus : MonoBehaviour
{

	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
				
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

	public void QuitarJuego()
	{
		Application.Quit();
	}

}