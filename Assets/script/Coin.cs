using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource _audioSource;
    private GameObject CoinCollectedEffect;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col + " entered this");
        if (!col.gameObject.CompareTag("Player"))
            return;

        if (CoinCollectedEffect != null)
        {
            GameObject.Instantiate(CoinCollectedEffect);
        }

        _audioSource.Play();
        Destroy(gameObject);
        
    }

}
