using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerMancionDerecho : MonoBehaviour {

    public GameObject MancionDerecho;
    public GameObject ParedDerecha;
    bool DentroDeTrigger = false;
    bool AparecerDerecho = false;
    bool DesaparecerDerecho = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TriggerDerecho")
        {
            DentroDeTrigger = true;
        }

        if (other.gameObject.name == "AparecerMansionDerecho")
        {
            AparecerDerecho = true;
        }

        if (other.gameObject.name == "DesaparecerMansionDerecho")
        {
            DesaparecerDerecho = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "TriggerDerecho" && AparecerDerecho == true)
        {
            MancionDerecho.SetActive(true);
            ParedDerecha.SetActive(false);
        }

        if (other.gameObject.name == "TriggerDerecho" && DesaparecerDerecho == true)
        {
            MancionDerecho.SetActive(false);
            ParedDerecha.SetActive(true);
        }

        if (other.gameObject.name == "TriggerDerecho")
        {
            DentroDeTrigger = false;
        }

        if (other.gameObject.name == "AparecerMansionDerecho")
        {
            AparecerDerecho = false;
        }

        if (other.gameObject.name == "DesaparecerMansionDerecho")
        {
            DesaparecerDerecho = false;
        }
    }
}
