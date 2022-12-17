using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]
    private Animator catapultAnimator;

    [SerializeField]
    private Animator catapultGuardAnimator;

    [SerializeField]
    private GameObject projectilePrefab;

    [SerializeField]
    private GameObject projectileSpawner;

    [SerializeField]
    private GameObject ammunitionSocketInteractor;

    [SerializeField]
    private GameObject ammunitionDestroyer;

    public float projectileForce;


    public void ActivateLever()
    {
        catapultAnimator.SetBool("ReadyToShoot", false);
        catapultGuardAnimator.SetBool("CatapultShoots", true);
        ammunitionSocketInteractor.SetActive(false);
        ammunitionDestroyer.SetActive(true);
        StartCoroutine(ShootProjectile());
    }

    public void ReloadWheel()
    {
        catapultAnimator.SetBool("ReadyToShoot", true);
        catapultGuardAnimator.SetBool("CatapultShoots", false);
        ammunitionSocketInteractor.SetActive(true);
        ammunitionDestroyer.SetActive(false);
    }

    IEnumerator ShootProjectile()
    {
        yield return new WaitForSeconds(0.3f);
        GameObject spawnedProjectile = Instantiate(projectilePrefab, projectileSpawner.transform);
        spawnedProjectile.transform.SetParent(null);
        Rigidbody projectileRigidbody = spawnedProjectile.GetComponent<Rigidbody>();
        projectileRigidbody.AddForce(projectileSpawner.transform.forward * projectileForce);
    }
}
