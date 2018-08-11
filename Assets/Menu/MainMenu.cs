using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public Button startButton;
    public Button InstructionsButton;

    void Start () {
        startButton.onClick.AddListener(startGame);
	}
	
	private void startGame()
    {
        SceneManager.LoadScene("Project Thingy");
    }
}
