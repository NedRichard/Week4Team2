using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 10f;
    public Rigidbody playerBody;
    float movementX;

    Vector3 forceM;

    void Awake() {
        playerBody = GetComponent<Rigidbody>();
    }

    void Update() {
        //movementX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        forceM = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, 0);
    }
    
    void FixedUpdate()
    {
        //Move();
        AddForceMovement(forceM);
    }

    void AddForceMovement(Vector3 direction) {
        playerBody.AddForce(direction);
    }

    void Move() {
        Vector3 velocity = playerBody.velocity;

        velocity.x = movementX;

        playerBody.velocity = velocity;
    }
}
