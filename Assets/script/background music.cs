using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class backgroundmusic : MonoBehaviour
{
    public AudioSource _AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        _AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayMusic();
    }

    public void PlayMusic()
    {
        if (_AudioSource == null)
            _AudioSource.Play();
    }
}
