using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    void StartGame() {
        Debug.Log("Welcome");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push up = higher");
        Debug.Log("Push down = lower");
        max = +1;
    }

    // Update is called once per frame
    void Update() {

        if(guess == 500) {
            Debug.Log("Your guess is 500");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than .." + guess);
            Debug.Log(guess);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {     
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than .." + guess);
            Debug.Log(guess);
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("I knew it");
        }

        
    }
}
