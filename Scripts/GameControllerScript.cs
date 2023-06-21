using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public UnityEngine.UI.Image menu;
    public UnityEngine.UI.Button startButton;

    public UnityEngine.UI.Text scoreView;
    public int score;

    public bool isStarted = false;
    
    public static GameControllerScript instance;

    void Start()
    {
        instance = this;

        startButton.onClick.AddListener(delegate 
        { 
            menu.gameObject.SetActive(false);
            startButton.gameObject.SetActive(false);
            isStarted = true;
        });
    }

    // Update is called once per frame
    void Update()
    {
        scoreView.text = "Очки: " + score;
    }
}
