using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger : MonoBehaviour
{
    [SerializeField]
    private Rigidbody flagRigidbody;

    // Detta skript läser av en trigger precis framför borgen, vilken ger flaggan en rigidbody precis innan projektilerna träffar sitt mål
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            flagRigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
