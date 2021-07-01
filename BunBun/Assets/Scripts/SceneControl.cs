using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public static void GoToGameView() {
        SceneManager.LoadScene("GameView");
    }

    public static void QuitGame() {
        Application.Quit();
    }
}
