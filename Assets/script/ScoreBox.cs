using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    private Score _score;

    // Start is called before the first frame update
    void Start()
    {
        _score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.gameObject.CompareTag("Player"))
                return;

            if (_score == null)
                return;

            _score.AddScore();
        }
}
