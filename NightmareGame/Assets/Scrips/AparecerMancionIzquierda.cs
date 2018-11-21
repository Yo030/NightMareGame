using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerMancionIzquierda : MonoBehaviour {

    public GameObject MancionIzquierdo;
    public GameObject ParedIzquierda;
	bool DentroDeTrigger = false;
    bool AparecerIzquierdo = false;
    bool DesaparecerIzquierdo = false;

    private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "TriggerIzquierdo")
		{
			DentroDeTrigger = true;
		}

        if (other.gameObject.name == "AparecerMansionIzquierdo")
        {
            AparecerIzquierdo = true;
        }

        if (other.gameObject.name == "DesaparecerMansionIzquierdo")
        {
            DesaparecerIzquierdo = true;
        }
    }

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == "TriggerIzquierdo" && AparecerIzquierdo == true)
		{
			MancionIzquierdo.SetActive(true);
            ParedIzquierda.SetActive(false);
		}

        if (other.gameObject.name == "TriggerIzquierdo" && DesaparecerIzquierdo == true)
        {
            MancionIzquierdo.SetActive(false);
            ParedIzquierda.SetActive(true);
        }

        if (other.gameObject.name == "TriggerIzquierdo")
        {
            DentroDeTrigger = false;
        }

        if (other.gameObject.name == "AparecerMansionIzquierdo")
        {
            AparecerIzquierdo = false;
        }

        if (other.gameObject.name == "DesaparecerMansionIzquierdo")
        {
            DesaparecerIzquierdo = false;
        }
    }
}
