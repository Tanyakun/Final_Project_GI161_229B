using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GetCoin[] coinPrefabs; // Polymorphism: ใช้ Array ที่เก็บ Coin ได้ทุกชนิด
    public float spawnInterval = 2f;
    public Transform groundLevel; // จุดพื้นดินที่ศัตรูควร Spawn
    public float spawnOffsetY = 0.5f; // ระยะยกจากพื้น

    void Start()
    {
        InvokeRepeating("SpawnCoin", spawnInterval, spawnInterval);
    }

    void SpawnCoin()
    {
        // เลือกศัตรูแบบสุ่ม
        int randomIndex = Random.Range(0, coinPrefabs.Length);
        GetCoin getCoin = Instantiate(coinPrefabs[randomIndex]);
        getCoin.Speed = Random.Range(3f, 8f); // Polymorphism: ตั้งค่าความเร็วแบบไดนามิก

        // กำหนดตำแหน่งให้ศัตรูอยู่บนพื้น
        float spawnX = transform.position.x;
        float spawnY = groundLevel.position.y + spawnOffsetY;

        getCoin.transform.position = new Vector3(spawnX, spawnY, 0f);
    }
}
