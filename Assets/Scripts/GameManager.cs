using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0; // หยุดเกม
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        // รีเซ็ตเกม
    }
}
