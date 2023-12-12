using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_music : MonoBehaviour
{
    private DetectColisionCoins gameOverScript;
    private AudioSource StopMusic;

    private void Start()
    {
        gameOverScript = FindObjectOfType<DetectColisionCoins>();
        StopMusic = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (gameOverScript.isGameOver == true)
        {
            StopMusic.Stop();
        }
    }

}
