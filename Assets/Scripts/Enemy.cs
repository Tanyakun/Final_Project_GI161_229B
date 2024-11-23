﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float speed; // Encapsulation: ซ่อนค่า speed และกำหนดผ่าน Property

    public float Speed
    {
        get { return speed; }
        set { speed = Mathf.Clamp(value, 1f, 10f); } // จำกัดค่า speed ไม่ให้เกิน 10
    }

    public float moveSpeed = 5f; // ความเร็วของศัตรู
    void Update()
    {
        // เคลื่อนที่ไปทางซ้ายตลอดเวลา
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

    // Move จะให้คลาสลูก Override
    protected abstract void Move();

    // พฤติกรรมชนกับผู้เล่น
    protected abstract void OnCollideWithPlayer();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnCollideWithPlayer();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
