using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float bounceForce = 10f;

    void OnCollisionEnter(Collision col) {

        Rigidbody body = col.gameObject.GetComponent<Rigidbody>();

        if(body != null) {

            Vector3 velo = body.velocity;
            velo.y = bounceForce;
            body.velocity = velo;
        }
    }
}
