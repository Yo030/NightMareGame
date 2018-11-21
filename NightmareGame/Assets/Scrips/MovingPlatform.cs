using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public GameObject Jugador;
    public GameObject PlataformaMov;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LogTrigger")
        {
            Jugador.transform.parent = PlataformaMov.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "LogTrigger")
        {
            Jugador.transform.parent = null;
        }
    }

}
