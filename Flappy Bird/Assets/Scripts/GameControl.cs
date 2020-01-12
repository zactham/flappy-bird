using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;

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

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
