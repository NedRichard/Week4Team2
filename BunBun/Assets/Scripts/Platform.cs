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

    void Awake() {
        platformBody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col) {
        Rigidbody body = col.gameObject.GetComponent<Rigidbody>();

        AddBounceVelocity(body);

        //RemovePlatform(platformBody);
        
    }

    void RemovePlatform(Rigidbody platform) {

        if(platform != null) {

            //Vector3 remove = new Vector3(0, 0, 5);

            //Moves platform but cannot be stopped
            //platform.AddForce(remove);

            //Moves to position instantly
            //platform.MovePosition(transform.position + (remove * platformSpeed * Time.deltaTime));

            Vector3 removePos = transform.position + offset;

            Vector3 finalPos = Vector3.SmoothDamp(transform.position, removePos, ref velo, platformSpeed * Time.deltaTime);
            
        }
    }

    void AddBounceVelocity(Rigidbody body) {

        if(body != null) {

            Vector3 velo = body.velocity;
            velo.y = bounceForce;
            body.velocity = velo;
            
        }
        
    }

    void AddBounceForce() {

    }

    void LateUpdate() {
        
    }
}
