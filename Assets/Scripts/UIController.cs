using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        // Loading the game scene
        SceneManager.LoadScene("Game");
    }

    public void OnExitButtonClicked()
    {
        // Exiting the game 
        Application.Quit();
    }
}
