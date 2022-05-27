using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void retryGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
