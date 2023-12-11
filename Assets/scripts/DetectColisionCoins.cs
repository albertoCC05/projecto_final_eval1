using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DetectColisionCoins : MonoBehaviour
{

    //variables

     private string BadCoinTag = "Bad_Coin";
     private string GoodCoinTag = "Good_Coin";
     private int lives = 3;
    public bool isGameOver = false;
    private int points = 0;
    private DestroyCoins DestroyCoinsScript;
    [SerializeField] private ParticleSystem goodCoin;
    [SerializeField] private ParticleSystem badCoin;
    [SerializeField] private ParticleSystem death;
    private Animator colisionAnimation;
    [SerializeField] private AudioClip getGoodCoin;
    [SerializeField] private AudioClip getBadCoin;
    [SerializeField] private AudioClip DeathAudio;
    private AudioSource PlayerAudioSource;


    //funciones


    public void SubstractALive()
    {
        lives = lives - 1;
        Debug.Log($" you have {lives} lives");
        GameOver();
    }
    
    private void GameOver()
    {
        if (lives == 0)
        {
            isGameOver = true;
            Debug.Log("YOU LOSE");
            Instantiate(death, transform.position, Quaternion.identity);
           PlayerAudioSource.PlayOneShot(DeathAudio,0.6f);
        }
    }

    //start, update, etc

    private void Awake()
    {
        colisionAnimation = GetComponent<Animator>();
        PlayerAudioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        Debug.Log($" you have {lives} lives");
        
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag(BadCoinTag))
        {

            Destroy(other.gameObject);
            SubstractALive();
            
            Instantiate(badCoin, transform.position, Quaternion.identity);
            colisionAnimation.SetTrigger("colision");
            PlayerAudioSource.PlayOneShot(getBadCoin,1f);
        }
        if (other.gameObject.CompareTag(GoodCoinTag))
        {
            DestroyCoinsScript = other.gameObject.GetComponent<DestroyCoins>();
            DestroyCoinsScript.CoinDestroyedByPlayer = true;
            Destroy(other.gameObject);
            points = points + 5;
            Instantiate(goodCoin, transform.position, Quaternion.identity);
            Debug.Log($"You have {points} points");
            PlayerAudioSource.PlayOneShot(getGoodCoin,0.6f);


        }
    }

   




}
