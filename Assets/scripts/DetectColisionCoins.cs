using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColisionCoins : MonoBehaviour
{
     private string BadCoinTag = "Bad_Coin";
     private string GoodCoinTag = "Good_Coin";



    //start, update, etc

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag(BadCoinTag))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag(GoodCoinTag))
        {
            Destroy(other.gameObject);
        }
    }

    
}
