using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadInstructions()
    {
        SceneManager.LoadScene(8);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene(9);
    }
}
