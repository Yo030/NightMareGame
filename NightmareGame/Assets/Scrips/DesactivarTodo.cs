using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarTodo : MonoBehaviour {

    public GameObject Cuarto;
    public GameObject PropsDeCementerio;
    public GameObject Cementerio;
    public GameObject Iglecia;
    public GameObject Bosque;
    public GameObject Mansion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "DesaparecerTodo")
        {
            Cuarto.SetActive(false);
            PropsDeCementerio.SetActive(false);
            Cementerio.SetActive(false);
            Iglecia.SetActive(false);
            Bosque.SetActive(false);
            Mansion.SetActive(false);
        }
    }
}
