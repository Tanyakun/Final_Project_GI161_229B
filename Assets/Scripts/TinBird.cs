using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinBird : Enemy
{
    // Override Method พฤติกรรมเฉพาะตัวของนกผอม
    protected override void Move()
    {
        transform.position = new Vector2(
            transform.position.x - Speed * Time.deltaTime,
            Mathf.Sin(Time.time) * 2 // บินขึ้นลง
        );
    }

    // Override Method แสดงข้อความตอนผู้เล่นชนกับนกผอม
    protected override void OnCollideWithPlayer()
    {
        Debug.Log("Player hit by TinBird! Game Over.");
        GameManager.Instance.GameOver();
    }
}
