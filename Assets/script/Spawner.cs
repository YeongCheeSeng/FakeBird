using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObstaclePrefebs;

    public float SpawnInterval = 1f;

    private float _timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _timer = SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if(_timer > 0f)
        {
            _timer -= Time.deltaTime;
            return;
        }

        _timer = SpawnInterval;

        int random = Random.Range(0, ObstaclePrefebs.Length);

        GameObject.Instantiate(ObstaclePrefebs[random], transform.position, transform.rotation);
    }
}
