using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmunitionTriggerScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //F�rst�r projektilen som spawnar i skopan
    }
}
