using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]
    private Animator catapultAnimator;

    public void ActivateLever()
    {
        catapultAnimator.SetBool("ReadyToShoot", false);
    }

    public void ReloadWheel()
    {
        catapultAnimator.SetBool("ReadyToShoot", true);
    }
}
