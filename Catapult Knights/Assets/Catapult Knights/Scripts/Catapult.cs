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

    public float projectileForce; // H�ller koll p� v�rdet av projektilkraften


    public void ActivateLever() //Aktiverar Coroutinen nedan
    {
        StartCoroutine(LeverActivation());
    }

    IEnumerator LeverActivation()
    {
        catapultAudioSource.Play(); // B�rjar spela ljudet i b�rjan
        yield return new WaitForSeconds(0.3f); // V�ntar en kort stund f�r ljudet och animationen ska matcha ihop
        catapultAnimator.SetBool("ReadyToShoot", false); // Aktiverar skjutanimationen
        catapultGuardAnimator.SetBool("CatapultShoots", true); // Aktiverar riddarens animation bredvid spelaren
        ammunitionSocketInteractor.SetActive(false); // St�nger av socket interaktorn
        ammunitionDestroyer.SetActive(true); // S�tter p� triggern som f�rst�r projektilen
        StartCoroutine(ShootProjectile()); // Aktiverar Coroutinen nedan
    }

    IEnumerator ShootProjectile()
    {
        yield return new WaitForSeconds(0.3f); // V�ntar yterligare en kort stund s� animationen hinner avslutas
        GameObject spawnedProjectile = Instantiate(projectilePrefab, projectileSpawner.transform); // Skapar en projektil av prefaben Rock Ammunition
        spawnedProjectile.transform.SetParent(null); // Ser till att den inte �r en child l�ngre av objektet som skapade den
        Rigidbody projectileRigidbody = spawnedProjectile.GetComponent<Rigidbody>(); // Ger projektilen en Rigidbody
        projectileRigidbody.AddForce(projectileSpawner.transform.forward * projectileForce); // Sist ger projektilen en kraft fram�t (Avg�rs av CatapultForceLever)
    }

    public void ReloadWheel() // Laddar om katapulten
    {
        catapultAnimator.SetBool("ReadyToShoot", true); // S�tter s� att man kan skjuta igen n�r animationen n�tt sitt slut (Laddat om helt)
        catapultGuardAnimator.SetBool("CatapultShoots", false); // Riddaren bradvid slutar ge tummen upp
        ammunitionSocketInteractor.SetActive(true); // Aktiverar Socket Interaktorn p� nytt
        ammunitionDestroyer.SetActive(false); // Sist st�nger av projektilf�rst�raren
    }
}
