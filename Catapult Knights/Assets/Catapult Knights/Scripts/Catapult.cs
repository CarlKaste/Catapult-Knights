using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]
    private Animator catapultAnimator;

    [SerializeField]
    private GameObject ammunitionSocketInteractor;

    [SerializeField]
    private GameObject projectile;

    public void ActivateLever()
    {
        catapultAnimator.SetBool("ReadyToShoot", false);
        ammunitionSocketInteractor.SetActive(false);
    }

    public void ReloadWheel()
    {
        catapultAnimator.SetBool("ReadyToShoot", true);
        ammunitionSocketInteractor.SetActive(true);
    }

    void ProjectileShoot()
    {

    }
}
