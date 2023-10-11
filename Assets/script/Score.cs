using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public AudioSource audioSource;
    public int TotalScore = 0;
    public TMP_Text Text;

    void Start()
    {
        TotalScore = 0;
        audioSource = GetComponent<AudioSource>();
    }
    public void AddScore(int score = 10)
    {
        Debug.Log("Add score " + score);
        audioSource.Play();
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
