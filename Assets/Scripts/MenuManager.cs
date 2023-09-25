using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1-0");
    }

    public void ShowControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void HideControls()
    {
        SceneManager.LoadScene("Main Menu");
    }
}