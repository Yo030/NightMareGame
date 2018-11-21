using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaparecerIglecia : MonoBehaviour
{

    public GameObject IgleciaReal;
    public GameObject IgleciaFalso;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "DesaparecerIglecia")
        {
            //////////////	  APARECE IgleciaFalso	  //////////////
            //////////////DESAPARECE IgleciaReal//////////////
            Debug.Log("IgleciaReal Desaparecio");
            Debug.Log("IgleciaFalso Aparecio");
            IgleciaReal.SetActive(false);
            IgleciaFalso.SetActive(true);
        }
    }
}
