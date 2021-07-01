using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {

        if(other.tag == "Player") {
            Debug.Log("Reached goal!");
            //SceneControl.GoToVictoryScene();
        }

    }
}
