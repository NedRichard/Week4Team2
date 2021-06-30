using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 10f;
    public Rigidbody playerBody;
    float movementX;

    void Awake() {
        playerBody = GetComponent<Rigidbody>();
    }

    void Update() {
        movementX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
    }
    
    void FixedUpdate()
    {
        Move();
    }

    void AddForceMovement() {
        
    }

    void Move() {
        Vector3 velocity = playerBody.velocity;

        velocity.x = movementX;

        playerBody.velocity = velocity;
    }
}
