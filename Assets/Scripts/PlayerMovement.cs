using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float mouseSensitivity = 0.04f;
    public float xBoundary = 7.0f;
    public ParticleSystem goodParticles;
    public ParticleSystem badParticles;

    public bool isGameOver = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X"); // gather user input

        if (!isGameOver) {
            transform.Translate(mouseX * mouseSensitivity, 0, 0);
        }

        if (transform.position.x > xBoundary) { // set player boundaries
            transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xBoundary) {
            transform.position = new Vector3(-xBoundary, transform.position.y, transform.position.z);
        }

    }
}
