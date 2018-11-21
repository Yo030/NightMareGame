using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarCementerio : MonoBehaviour {
	
    public GameObject Cementerio;
    public GameObject Bosque;
    public GameObject PropsDeCementerio;
    public GameObject Mancion;
	bool StillInside = false;
	bool Safty = false;
	bool PosibilidadDeCambiarACementerio = false;



	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "DesaparecerCementerio" && Cementerio.activeSelf == true && Safty == true)
		{
			//////////////	  APARECE BOSQUE	  //////////////
			//////////////DESAPARECE CEMENTERIO//////////////
			Debug.Log("Cementerio Desaparecio");
			Debug.Log("Bosque Aparecio");
			Cementerio.SetActive(false);
			Bosque.SetActive(true);
            Mancion.SetActive(true);
            PropsDeCementerio.SetActive(false);
			StillInside = true;
		}

		if (other.gameObject.name == "AparecerCementerio")
		{
			Debug.Log("ENTER SAFTY TRIGGER");
			Safty = true;
		}

	}

    private void OnTriggerExit(Collider other)
    {
		if (other.gameObject.name == "DesaparecerCementerio" && Cementerio.activeSelf == false)
		{
			StillInside = false;
		}

		if (other.gameObject.name == "AparecerCementerio")
		{
			Debug.Log("EXIT SAFTY TRIGGER");
			Safty = false;			
		}

		if (other.gameObject.name == "DesaparecerCementerio" && Cementerio.activeSelf == false && Safty == true)
		{
			//////////////DESAPARECE BOSQUE//////////////
			//////////////APARECE CEMENTERIO//////////////
			Debug.Log("Bosque Desaparecio");
			Debug.Log("Cementerio Aparecio");
			Cementerio.SetActive(true);
			Bosque.SetActive(false);
            Mancion.SetActive(false);
            PropsDeCementerio.SetActive(true);
			StillInside = false;
		}

	}
}
