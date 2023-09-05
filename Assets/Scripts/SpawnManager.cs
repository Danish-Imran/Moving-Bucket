using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacleArray;
    public Rigidbody obstacleRb;
    public PlayerMovement playerScript;

    private float spawnFrequency = 1.5f;
    private float boundary = 7;
    private float yHeight = 8;

    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();

        InvokeRepeating("SpawnObstacle", 1.0f, spawnFrequency);
        InvokeRepeating("SpawnObstacle", 0, spawnFrequency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerScript.isGameOver == false) {
            int randomIndex = Random.Range(0, obstacleArray.Length);
            Instantiate(obstacleArray[randomIndex], new Vector3(Random.Range(-boundary, boundary), yHeight), transform.rotation); // generate random object at random position
        }
    }
}
