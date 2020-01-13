using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public Text scoreText;

    private int score = 0;

    // Called before anything occurs
    void Awake()
    {
        //No game control found
        if (instance == null)
            instance = this; // sets the instance as this will be the game control
        else if (instance != this) //instance exists
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Game is over and player wants the bird to flap
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            //Reload the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        //Adds one to the score
        score++;
        //Displays the score
        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }


}
