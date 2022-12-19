using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Ett som håller koll på händelser och UI i spelet

    [SerializeField]
    private GameObject introductionScreen;

    [SerializeField]
    private GameObject firstCatapultInstructionScreen;

    [SerializeField]
    private GameObject secondCatapultInstructionScreen;

    [SerializeField]
    private GameObject gameInstructionScreen;

    [SerializeField]
    private GameObject levelWonScreen;

    [SerializeField]
    private GameObject gameWonScreen;

    [SerializeField]
    private GameObject gameLostScreen;

    [SerializeField]
    private GameObject retryButton;

    private int selectedScreen; // Håller värdet på vilken Tutorial screen som är aktiv 

    public bool fortDestroyed; // Kollar om borgen blivit förstörd. Aktiveras under GameWon() funktionen


    private void Update()
    {
        if(selectedScreen == 1) // Aktiverar 1a tutorialrutan
        {
            introductionScreen.SetActive(true);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(false);
        }
        if (selectedScreen == 2) // Aktiverar 2a tutorialrutan
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(true);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(false);
        }
        if (selectedScreen == 3) // Aktiverar 3e tutorialrutan
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(true);
            gameInstructionScreen.SetActive(false);
        }
        if (selectedScreen == 4) // Aktiverar 4e tutorialrutan
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(true);
        }
        if (selectedScreen == 5) // Ser till att alla tutorialrutor är stängda och sedan aktiverar den synliga Retry-knappen
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(false);
            retryButton.SetActive(true);
        }
    }

    public void NextScreen() // Växlar framåt av tutorialrutorna
    {
        selectedScreen++;
    }
    public void PreviousScreen() // Växlar bakåt av tutorialrutorna
    {
        selectedScreen--;
    }
    /*
    public void LevelWon() // Potentiell funktion för framtida extra levlar (Han inte göra mer)
    {
        levelWonScreen.SetActive(true);
    }
    */
    public void NextLevel() // Växlar från Main Menu till Game scenen
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(StartIntroduction()); 
    }

    IEnumerator StartIntroduction() // Startas i funktionen över. Väntar en sekund innan första turorialfönstret öppnas
    {
        yield return new WaitForSeconds(1);
        selectedScreen = 1;
    }

    public void RestartLevel() // Anropas vid tryck av Retry-knappen
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void GameWon() // Anropas då flaggan fallit ur FortTrigger:n
    {
        gameWonScreen.SetActive(true);
        fortDestroyed = true; // Läses av av fiendekaraktärerna och aktiverar deras animation (skript: EnemyKnights)
    }

    public void EndGame() //Anropas då man vunnit och trycker på Main Menu-knappen. Går tillbaka till menyn
    {
        gameWonScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame() // Anropas via Quit-knappen i Main Menu
    {
        Application.Quit();
    }
}
