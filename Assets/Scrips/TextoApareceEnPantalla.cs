using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoApareceEnPantalla : MonoBehaviour {

    public GameObject Texto;
    public GameObject Fire;
    public GameObject Self;
    public GameObject New;
    bool inTrigger = false;

    void Update()
    {
        if (Input.GetButtonUp("Jump") && inTrigger == true)
        {
            Self.SetActive(false);
            New.SetActive(true);
        }



    }

    void LateUpdate()
    {
        if (Self.activeSelf == false)
        {
            Texto.SetActive(false);
            inTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vela")
        {
            Texto.SetActive(true);
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Vela")
        {
            Texto.SetActive(false);
            inTrigger = false;
        }
    }
}
