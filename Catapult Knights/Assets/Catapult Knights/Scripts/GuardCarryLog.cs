using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardCarryLog : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private bool carriesLog = true;

    private Vector3 startPosition = new Vector3(7, 0, -18);
    private Vector3 endPosition = new Vector3(1, 0, 14);

    private float speed;

    // Update is called once per frame
    void Update()
    {
        if (carriesLog)
        {
            transform.LookAt(endPosition);
            transform.position = transform.forward * speed * Time.deltaTime;
            animator.SetBool("IsCarryingLog", true);
            
        }
    }
}
