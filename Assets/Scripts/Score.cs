using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instance;
    public TextMeshProUGUI _scoreText ;
    public TextMeshProUGUI _highScoreText ;
    public TextMeshProUGUI _sessionScoreText;

    public int _scoreValue = 0;
    public int _sessionScore = 0;
    public int highScore = 0;

    private void Awake()
    {
        _scoreValue = 0;
        instance = this;
        TextMeshPro _scoreText = GetComponent<TextMeshPro>();
        TextMeshPro _highscoreText = GetComponent<TextMeshPro>();
       
        if (PlayerPrefs.HasKey("highScore"))
        {
            highScore = PlayerPrefs.GetInt("highScore");
            _highScoreText.text = "HighScore: " + highScore.ToString();
        }

        
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            _sessionScore = PlayerPrefs.GetInt("Score");
            _sessionScoreText.text = "Session Score: " + _sessionScore.ToString();
        }
    }

    public void AddScore()
    {
        _scoreValue += 10;
        _scoreText.text = "Score: " + _scoreValue.ToString();
        SaveScore();
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        if (_scoreValue > highScore)
        {
            highScore = _scoreValue;
            _highScoreText.text = "Highscore: " + highScore.ToString();
            PlayerPrefs.SetInt("highScore", highScore);

        }
    }

    public void SaveScore()
    {
            _sessionScore = _scoreValue;
            PlayerPrefs.SetInt("Score", _sessionScore);
            _sessionScoreText.text = "Score:" + _sessionScore.ToString();
        
    }

}

