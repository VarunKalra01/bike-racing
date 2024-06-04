using System.Collections;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("ERROR!");
            return;
        }

        StartCoroutine(IncreaseScoreOneSecond());
    }

    IEnumerator IncreaseScoreOneSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            score++;
            scoreText.text = "Score: " + score;
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}
