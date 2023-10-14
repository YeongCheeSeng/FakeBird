using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.gameObject.CompareTag("Player"))
            return;

        Destroy(col.gameObject);
        SceneManager.LoadScene("FakeBird (End menu)");
    }
}
