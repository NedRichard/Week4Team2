using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        SceneControl.GoToGameView();
    }
}
