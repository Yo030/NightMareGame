using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoAmbienteOptimizado : MonoBehaviour {

    public AudioSource aCementerio;


	// Use this for initialization
	void Start ()
    {
        aCementerio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay (Collider other)
    {
        if(other.gameObject.name == "Bosque")
        {
            if (!aCementerio.isPlaying)
            {
                aCementerio.Play();
            }
        }

        if (other.gameObject.name == "Cementerio")
        {
            if (!aCementerio.isPlaying)
            {
                aCementerio.Play();
            }
        }

        if (other.gameObject.name == "Mansion")
        {
            if (!aCementerio.isPlaying)
            {
                aCementerio.Play();
            }
        }

        if (other.gameObject.name == "Cuarto")
        {
            if (!aCementerio.isPlaying)
            {
                aCementerio.Play();
            }
        }
    }




}
