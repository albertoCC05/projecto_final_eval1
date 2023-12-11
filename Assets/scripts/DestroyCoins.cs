using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoins : MonoBehaviour
{
    //variables

    private DetectColisionCoins gameOverScript;
    public bool CoinDestroyedByPlayer;

    //update / start

    private void Start()
    {
        gameOverScript = FindObjectOfType<DetectColisionCoins>();
    }

    private void Awake ()
    {


        Destroy(gameObject, 5f);      
    }

    private void OnDestroy()
    {
        if (gameObject.CompareTag("Good_Coin") && CoinDestroyedByPlayer == false)
        {
            gameOverScript.SubstractALive();
            
        }
    }
}
