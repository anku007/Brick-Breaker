using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    int score = 0;
    public float timeLeft = 40;
    public Text scoreText;
    public Text winText;
    public Text gameOverText;
    public Text timeLeftText;

    // Use this for initialization
    void Start () {
        winText.text = "";
        gameOverText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        timeLeftText.text = "Time Left: " + (int)timeLeft;
        if (timeLeft < 0)
        {
            gameOver();
        }
    }

    public void incrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        checkScore();
    }

    public void addTimer()
    {
        timeLeft += 5;
    }
    
    public void checkScore()
    {
        if (score == 20)
        {
            winText.text = "You Win!";
        }
    }

    public void gameOver()
    {
        gameOverText.text = "Game Over!";
    }
}
