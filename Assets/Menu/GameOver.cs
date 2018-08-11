using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public Button startButton;
    public Button mainmenuButton;

    void Start () {
        startButton.onClick.AddListener(startGame);
        mainmenuButton.onClick.AddListener(startMenu);
    }

    private void startGame()
    {
        SceneManager.LoadScene("Project Thingy");
        Time.timeScale = 1f;
    }

    private void startMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
