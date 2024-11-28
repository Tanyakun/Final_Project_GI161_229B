using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy[] enemyPrefabs; // Polymorphism: ใช้ Array ที่เก็บ Enemy ได้ทุกชนิด
    public float spawnInterval = 2f;
    public Transform groundLevel; // จุดพื้นดินที่ศัตรูควร Spawn
    public float spawnOffsetY = 0.5f; // ระยะยกจากพื้น

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        // เลือกศัตรูแบบสุ่ม
        int randomIndex = Random.Range(0, enemyPrefabs.Length);
        Enemy enemy = Instantiate(enemyPrefabs[randomIndex]);
                                            
        // กำหนดตำแหน่งให้ศัตรูอยู่บนพื้น
        float spawnX = transform.position.x;
        float spawnY = groundLevel.position.y + spawnOffsetY;

        enemy.transform.position = new Vector3(spawnX, spawnY, 0f);
    }
}

