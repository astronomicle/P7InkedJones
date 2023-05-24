using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private GameManager gameManager;
    public Button startButton;

    void Start()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(PlayGame);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void PlayGame()
    {
        gameManager.StartGame();
    }
}