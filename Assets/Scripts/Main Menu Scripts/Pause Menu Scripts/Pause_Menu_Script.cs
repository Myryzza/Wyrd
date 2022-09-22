using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause_Menu_Script : MonoBehaviour
{
    public static bool dIsGamePaused = false;

    public GameObject dPauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(dIsGamePaused)
                mResumeGame();
            else
                mPauseGame();
        }
        
    }

    public void mResumeGame()
    {
        dPauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        dIsGamePaused = false;
    }

    void mPauseGame()
    {
        dPauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        dIsGamePaused = true;
    }

    public void mMainMenu()
    {
        //Should probably remind player that unsaved progress should be saved
        SceneManager.LoadScene("MainMenu");
    }

    public void mSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void mQuit()
    {
        //Should probably remind player that unsaved progress should be saved
        //Also should probably go through some exit protocol
        Application.Quit();
    }
}
