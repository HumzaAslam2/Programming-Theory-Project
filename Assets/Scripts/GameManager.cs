using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Start()
    {
        if (Instance != null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitBackToStartMenu()
    {
        SceneManager.LoadScene(0);
    }
}
