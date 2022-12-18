using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortTrigger : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Flag"))
        {
            gameManager.GameWon();
        }
    }
}
