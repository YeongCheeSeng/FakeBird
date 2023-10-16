using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    private Score _score;
    public GameObject CoinCollectedEffect;

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

        
            GameObject.Instantiate(CoinCollectedEffect, transform.position, Quaternion.identity);
        

            _score.AddScore();
            Destroy(this.gameObject);
        }
}
