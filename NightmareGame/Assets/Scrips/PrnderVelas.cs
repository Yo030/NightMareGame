using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrnderVelas : MonoBehaviour {

    int numVelasPren = 0;
    public GameObject Candelarios;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if (numVelasPren == 4)
        {
            Candelarios.SetActive(true);
        }


	}
}
