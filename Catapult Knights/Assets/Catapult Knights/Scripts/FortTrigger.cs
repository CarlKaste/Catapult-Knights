using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortTrigger : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    // Detta skript kollar om flaggan ramlat ur triggerzonen och där efter aktiverar funktionen GameWon() 
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Flag")) 
        {
            gameManager.GameWon(); 
        }
    }
}
