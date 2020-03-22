using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{

public Text gameOver;
public RocketMovement rocket;


    void Start()
    {
        gameOver = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    if(rocket.dead == true){

        gameOver.text = "GAME OVER" ;
        Time.timeScale = 0.0f; // to stop the game
    }
    }
}
