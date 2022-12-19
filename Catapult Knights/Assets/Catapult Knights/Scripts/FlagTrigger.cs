using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger : MonoBehaviour
{
    [SerializeField]
    private Rigidbody flagRigidbody;

    // Detta skript l�ser av en trigger precis framf�r borgen, vilken ger flaggan en rigidbody precis innan projektilerna tr�ffar sitt m�l
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            flagRigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
