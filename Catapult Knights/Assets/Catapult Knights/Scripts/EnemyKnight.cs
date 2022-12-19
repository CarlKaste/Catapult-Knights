using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnight : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private Animator animator;

    private void Update() // Gör så att fienderiddarna faller platt på marken då man slagit ner flaggan (då funktionen GameWon() anropats)
    {
        if(gameManager.fortDestroyed == true)
        {
            animator.SetBool("FortDestroyed", true); // Aktiverar animationen
        }
    }
}
