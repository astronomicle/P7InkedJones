using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private bool isGameActive;
    public GameObject titleScreen;
    public Button startButton;
    public Button continueButton;
    private PlayerController PCS;
   

    void Start()
    {
        isGameActive = false;
        PCS = GameObject.Find("Sam").GetComponent<PlayerController>();
    }

    public void StartGame()
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        
    }

    void Update()
    {
        if (isGameActive == true)
        {
            PCS.Shooting();
        }
    }
}
