using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {

        if(other.tag == "Player") {
            SceneControl.GoToGameView();
        }
        
    }
}
