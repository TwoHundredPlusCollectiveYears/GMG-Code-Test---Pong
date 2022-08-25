using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    static private GameManager instance;
    static public GameManager Instance 
    {
        get 
        {
            if (instance == null)
            {
                Debug.LogError("There is no GameManager instance in the scene.");
            }
            return instance;
        }
    }

    public Ball ball;
    public GameObject gameOverPanel;
    public GameObject menuPanel;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    private int player1Score;
    private int player2Score;
    
    void Awake()
    {
        if (instance != null) 
        {
        }
        else 
        {
            instance = this;
        }        
    }

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Menu")
        {
            menuPanel.SetActive(true);
        }
        else{
            ball = GameObject.Find("Ball").GetComponent<Ball>();
            player1Score = 0;
            player2Score = 0;
            player1ScoreText.text = player1Score.ToString();
            player2ScoreText.text = player2Score.ToString();
            gameOverPanel.SetActive(false);
        }
    }

    private void Update()
    {
        if (player1Score >= 11 || player2Score >= 11)
        {
            GameOver();
        }
    }

    public void player1Scores()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        ball.ResetBallPosition();
    }

    public void player2Scores()
    {   
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        ball.ResetBallPosition();

    }

    public void GameOver()
    {
  
        gameOverPanel.SetActive(true);
    }

    public void LoadMenu()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void Load1Player()
    {
        menuPanel.SetActive(false);
        SceneManager.LoadScene(1);
    }

    public void Load2Player()
    {
        menuPanel.SetActive(false);
        SceneManager.LoadScene(2);
    }
}


