using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables

    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    private float verticalBounds = 3.83f;
    private float horizontalBounds = 7.9f;
    private DetectColisionCoins gameOverScript;





    //funciones

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;

        if (pos.z > verticalBounds)
        {
            pos.z = verticalBounds;
        }
        if (pos.z < -verticalBounds)
        {
            pos.z = -verticalBounds;
        }
        if (pos.x > horizontalBounds)
        {
            pos.x = horizontalBounds;
        }
        if (pos.x < -horizontalBounds)
        {
            pos.x = -horizontalBounds;
        }
        transform.position = pos;
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        
    }
    private void Rotation()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontalInput);
        
    }


    //start/ update


    private void Start()
    {
        gameOverScript = FindObjectOfType<DetectColisionCoins>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
       
        if (gameOverScript.isGameOver == false)
        {
            MoveForward();
            Rotation();
            PlayerInBounds();
        }

        


    }



}
