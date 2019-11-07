using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button startGameButton;
    public string startGameSceneName;

    public void Awake()
    {
        startGameButton.onClick.AddListener(StartGame);
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(startGameSceneName);
    }

   
}
