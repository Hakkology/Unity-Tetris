using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Tetris");
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
