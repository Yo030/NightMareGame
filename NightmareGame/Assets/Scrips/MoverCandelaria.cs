using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCandelaria : MonoBehaviour {

	bool subir = false;
	public Transform destino;
	public float velocidad = 0.1f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonUp("Jump"))
		{
			subir = true;
		}
		if (subir == true)
		{
			transform.position = Vector3.MoveTowards(transform.position, destino.position, velocidad);
			//Debug.Log("Subiendo");
		}
	}
}
