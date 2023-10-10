using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource PlaySound;

    // Start is called before the first frame update
    void Start()
    {
        PlaySound = GetComponent<AudioSource>();
        PlaySound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
