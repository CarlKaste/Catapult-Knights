using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnight : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private Animator animator;

    private void Update() // G�r s� att fienderiddarna faller platt p� marken d� man slagit ner flaggan (d� funktionen GameWon() anropats)
    {
        if(gameManager.fortDestroyed == true)
        {
            animator.SetBool("FortDestroyed", true); // Aktiverar animationen
        }
    }
}
