using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text Score;
    public static int ScoreCount = 0;
    public static int HiScoreCount;
    public Text HiScore;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            HiScoreCount = PlayerPrefs.GetInt("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreCount > HiScoreCount)
        {
            HiScoreCount = ScoreCount;
            PlayerPrefs.SetInt("HighScore",HiScoreCount);
        }
        Score.text = "Score: " + Mathf.Round(ScoreCount);
        HiScore.text = "Hi-Score: " + Mathf.Round(HiScoreCount);
    }
    public void AddScore(int points)
    {
        ScoreCount += points;
    }
}
