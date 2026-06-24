using TMPro;
using UnityEngine;

public class ClickGame2D : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;

    private int score = 0; 
    private bool isGameOver = false;

    void Start()
    {
        UpdateScoreText();
        winText.gameObject.SetActive(false); 
    }

   
    void OnMouseDown()
    {
        
        if (isGameOver) return;

        score++; 
        UpdateScoreText(); 

       
        if (score >= 10)
        {
            WinGame();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score + " " + "/ 10";
    }

    void WinGame()
    {
        isGameOver = true;
        winText.gameObject.SetActive(true); 
    }
}
