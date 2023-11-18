using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static GameOver instance { get; private set; }
    public bool gameOver = false;

    public TMP_Text gameOverText;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        gameOverText.text = "";
    }
    

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // this loads the currently active scene
            }
        }
    }
    public void winGame()
    {
        Debug.Log("Win Game");
        gameOverText.text = "You win! Game created by Group 23. Press R to restart";
        gameOver = true;
        
    }
    public void loseGame()
    {
        Debug.Log("Lose Game");
        gameOverText.text = "You lose! Game created by Group 23. Press R to restart";
        gameOver = true;
        
    }
}
