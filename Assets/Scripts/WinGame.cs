using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    //public string sceneToLoad = "Level1";

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Player")
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
