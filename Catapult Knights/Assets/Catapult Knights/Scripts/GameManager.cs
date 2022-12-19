using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Ett som h�ller koll p� h�ndelser och UI i spelet

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

    private int selectedScreen; // H�ller v�rdet p� vilken Tutorial screen som �r aktiv 

    public bool fortDestroyed; // Kollar om borgen blivit f�rst�rd. Aktiveras under GameWon() funktionen


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
        if (selectedScreen == 5) // Ser till att alla tutorialrutor �r st�ngda och sedan aktiverar den synliga Retry-knappen
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(false);
            retryButton.SetActive(true);
        }
    }

    public void NextScreen() // V�xlar fram�t av tutorialrutorna
    {
        selectedScreen++;
    }
    public void PreviousScreen() // V�xlar bak�t av tutorialrutorna
    {
        selectedScreen--;
    }
    /*
    public void LevelWon() // Potentiell funktion f�r framtida extra levlar (Han inte g�ra mer)
    {
        levelWonScreen.SetActive(true);
    }
    */
    public void NextLevel() // V�xlar fr�n Main Menu till Game scenen
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(StartIntroduction()); 
    }

    IEnumerator StartIntroduction() // Startas i funktionen �ver. V�ntar en sekund innan f�rsta turorialf�nstret �ppnas
    {
        yield return new WaitForSeconds(1);
        selectedScreen = 1;
    }

    public void RestartLevel() // Anropas vid tryck av Retry-knappen
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void GameWon() // Anropas d� flaggan fallit ur FortTrigger:n
    {
        gameWonScreen.SetActive(true);
        fortDestroyed = true; // L�ses av av fiendekarakt�rerna och aktiverar deras animation (skript: EnemyKnights)
    }

    public void EndGame() //Anropas d� man vunnit och trycker p� Main Menu-knappen. G�r tillbaka till menyn
    {
        gameWonScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame() // Anropas via Quit-knappen i Main Menu
    {
        Application.Quit();
    }
}
