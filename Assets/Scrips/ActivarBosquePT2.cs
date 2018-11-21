using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarBosquePT2 : MonoBehaviour {

    public GameObject PT1;
    public GameObject PT2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ActivarBosquept2")
        {
            PT1.SetActive(false);
            PT2.SetActive(true);
        }
    }
}
