using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col + " entered this");
        if (!col.gameObject.CompareTag("Player"))
            return;

        _audioSource.Play();
        Destroy(this.gameObject);
       
    }

}
