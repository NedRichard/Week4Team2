using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float bounceForce = 10f;

    Rigidbody platformBody;

    public float platformSpeed = 10f;

    Vector3 offset = new Vector3(0, 0, 5);

    Vector3 velo = Vector3.zero;

    bool movePlatform = false;

    void Awake() {
        platformBody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col) {

        Rigidbody body = col.gameObject.GetComponent<Rigidbody>();

        //Using velocity
        //AddBounceVelocity(body);

        //Using force
        AddBounceForce(body);

        //Using 
        movePlatform = true;

        //Moved to Update
        //RemovePlatform(platformBody);

    }

    void RemovePlatform(Rigidbody platform) {

        if(platform != null) {

            Vector3 remove = new Vector3(0, 0, 5);

            //Moves platform but cannot be stopped
            //platform.AddForce(remove);

            //Moves to position instantly
            //platform.MovePosition(transform.position + (remove * platformSpeed * Time.deltaTime));

            //Vector3 removePos = transform.position + offset;

            //Vector3 finalPos = Vector3.SmoothDamp(transform.position, removePos, ref velo, platformSpeed * Time.deltaTime);
            
        }
    }

    void AddBounceVelocity(Rigidbody body) {

        if(body != null) {

            Vector3 velo = body.velocity;
            velo.y = bounceForce;
            body.velocity = velo;
            
        }
        
    }

    void AddBounceForce(Rigidbody player) {

        if( player != null) {

            Vector3 bounce = new Vector3(0, bounceForce * 50, 0);

            player.AddForce(bounce);

        }

    }

    void MovePlatform() {

        Vector3 remove = new Vector3(0, 0, 5);

        //platformBody.MovePosition(transform.position + (remove * platformSpeed * Time.deltaTime));

        Vector3 removePos = transform.position + offset;

        //Vector3 finalPos = Vector3.SmoothDamp(transform.position, removePos, ref velo, platformSpeed * Time.fixedDeltaTime);
    }

    void FixedUpdate() {

        //platformBody = GetComponent<Rigidbody>();

        if(movePlatform) {

            Debug.Log("Platform is moving!");

            MovePlatform();
        }
        
    }
}
