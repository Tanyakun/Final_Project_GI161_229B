using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhino : Enemy
{
    // Override Abstract Method แสดงข้อความตอนผู้เล่นชนกับแรด
    protected override void OnCollideWithPlayer()
    {
        Debug.Log("Player hit by Rhino! Game Over.");
        GameManager.Instance.GameOver();
    }
}
