using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody obstacleRb;
    public PlayerMovement playerScript;


    void Start()
    {
        obstacleRb = GetComponent<Rigidbody>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();

        obstacleRb.AddTorque(new Vector3(1500,0,1500)); // adds spin
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "In Bucket Collider" && gameObject.CompareTag("Good")) { // if obstacle lands inside of the bucket
            playerScript.goodParticles.Play();
        }
        else if (other.gameObject.name == "In Bucket Collider" && gameObject.CompareTag("Bad")) { // game ending obstacles
            playerScript.badParticles.Play();
            playerScript.isGameOver = true; // stop spawning objects and limit player movement
        }

        Destroy(gameObject); // save resources
    }
}

