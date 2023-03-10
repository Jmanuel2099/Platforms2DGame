using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject optionsPanel;

    public void showOptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void ReturnButton()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void SettingsButton()
    {
        //To do: Sound, grafics
        Debug.Log("To do: Sound, grafics..");
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }
}
