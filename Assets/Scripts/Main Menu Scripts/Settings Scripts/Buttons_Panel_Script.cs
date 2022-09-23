using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons_Panel_Script : MonoBehaviour
{
    public void mMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void mPlayGame()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void mSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void mQuitApplication()
    {
        Application.Quit();
    }
}
