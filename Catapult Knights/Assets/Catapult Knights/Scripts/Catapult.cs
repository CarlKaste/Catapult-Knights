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

    [SerializeField]
    private AudioSource catapultAudioSource;

    public float projectileForce; // Håller koll på värdet av projektilkraften


    public void ActivateLever() //Aktiverar Coroutinen nedan
    {
        StartCoroutine(LeverActivation());
    }

    IEnumerator LeverActivation()
    {
        catapultAudioSource.Play(); // Börjar spela ljudet i början
        yield return new WaitForSeconds(0.3f); // Väntar en kort stund för ljudet och animationen ska matcha ihop
        catapultAnimator.SetBool("ReadyToShoot", false); // Aktiverar skjutanimationen
        catapultGuardAnimator.SetBool("CatapultShoots", true); // Aktiverar riddarens animation bredvid spelaren
        ammunitionSocketInteractor.SetActive(false); // Stänger av socket interaktorn
        ammunitionDestroyer.SetActive(true); // Sätter på triggern som förstör projektilen
        StartCoroutine(ShootProjectile()); // Aktiverar Coroutinen nedan
    }

    IEnumerator ShootProjectile()
    {
        yield return new WaitForSeconds(0.3f); // Väntar yterligare en kort stund så animationen hinner avslutas
        GameObject spawnedProjectile = Instantiate(projectilePrefab, projectileSpawner.transform); // Skapar en projektil av prefaben Rock Ammunition
        spawnedProjectile.transform.SetParent(null); // Ser till att den inte är en child längre av objektet som skapade den
        Rigidbody projectileRigidbody = spawnedProjectile.GetComponent<Rigidbody>(); // Ger projektilen en Rigidbody
        projectileRigidbody.AddForce(projectileSpawner.transform.forward * projectileForce); // Sist ger projektilen en kraft framåt (Avgörs av CatapultForceLever)
    }

    public void ReloadWheel() // Laddar om katapulten
    {
        catapultAnimator.SetBool("ReadyToShoot", true); // Sätter så att man kan skjuta igen när animationen nått sitt slut (Laddat om helt)
        catapultGuardAnimator.SetBool("CatapultShoots", false); // Riddaren bradvid slutar ge tummen upp
        ammunitionSocketInteractor.SetActive(true); // Aktiverar Socket Interaktorn på nytt
        ammunitionDestroyer.SetActive(false); // Sist stänger av projektilförstöraren
    }
}
