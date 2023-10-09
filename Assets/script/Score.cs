using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public int TotalScore = 0;
    public TMP_Text Text;

    void Start()
    {
        TotalScore = 0;
    }
    public void AddScore(int score = 10)
    {
        Debug.Log("Add score " + score);
        TotalScore += score;
    }
    void Update()
    {
        if (Text != null)
        {
            Text.text = "Score: " + TotalScore.ToString();
        }
    }
}
