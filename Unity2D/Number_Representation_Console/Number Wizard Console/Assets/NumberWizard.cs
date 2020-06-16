using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }
    void StartGame()
    {
        max = 1000;
        min = 1;
         guess = 500;
        Debug.Log("Welcome to NumberWizard");
        Debug.Log("Pick a number what it is don't tell me");
        Debug.Log("The highest number you can choose is: " + max);
        Debug.Log("The lowest number you can choose is: " + min);
        Debug.Log("Tell me your number is higher or lower than: " + guess);
        Debug.Log("Pushup = Higher, Pushdown=Lower, Push Enter=Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius.");
            StartGame();
        }

    }
    void NextGuess(){
        guess = (min + max) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
