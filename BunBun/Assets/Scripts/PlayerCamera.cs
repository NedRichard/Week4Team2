using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;
    void LateUpdate()
    {
        if(target.position.y > transform.position.y) {

            Vector3 newPos = new Vector3(target.position.x, target.position.y, target.position.z);
            transform.position = newPos;
        }
    }
}
