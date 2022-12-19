using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnight : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private Animator animator;

    private void Update()
    {
        if(gameManager.fortDestroyed == true)
        {
            animator.SetBool("FortDestroyed", true);
        }
    }
}
