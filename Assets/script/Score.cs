using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    public AudioSource audioSource;
    public static int TotalScore;
    public TMP_Text Text;

    void Start()
    {   
        TotalScore = 0;
        audioSource = GetComponent<AudioSource>();
    }
    public int AddScore(int score = 10)
    {
        audioSource.Play();
        TotalScore += score;
        return TotalScore;
    }

    void Update()
    {
        if (Text != null)
        {
            Text.text = "Score: " + TotalScore.ToString();
        }
    }
}
