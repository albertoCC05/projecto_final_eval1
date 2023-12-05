using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    //variables

    [SerializeField] private GameObject[] SpawnArray;
    private float StartDelay = 2;
    private float DelayBetweenSpawns = 2;

    //funciones

   private void randomObject()
    {

    }
    private Vector3 randomSpawn()
    {
        float randomX = Random.Range(-7.9f, 7.9f);
        float randomZ = Random.Range(-3.83f, 3.83f);
        return new Vector3(randomX, 1, randomZ);
    }

    //update


    private void Update()
    {
        
    }
}
