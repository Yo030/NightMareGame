using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoAmbiente : MonoBehaviour {

    AudioSource Ambientacion;

	// Use this for initialization
	void Start ()
    {
        Ambientacion = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Ambientacion.volume += 0.005f;
            if (!Ambientacion.isPlaying)
            {
                Ambientacion.Play();
                Debug.Log("REPRODUCIENDO");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Ambientacion.volume = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Mathf.Clamp(Ambientacion.volume, 0.0f, 1.0f);
            Ambientacion.volume -= 0.1f;
        }
    }
}
