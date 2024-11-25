using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GetCoin[] coinPrefabs; // Polymorphism: ใช้ Array ที่เก็บ Coin ได้ทุกชนิด
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnCoin", spawnInterval, spawnInterval);
    }

    void SpawnCoin()
    {
        // เลือกเหรียญแบบสุ่ม
        int randomIndex = Random.Range(0, coinPrefabs.Length);
        GetCoin getCoin = Instantiate(coinPrefabs[randomIndex]);
        getCoin.Speed = Random.Range(3f, 8f); // Polymorphism: ตั้งค่าความเร็วแบบไดนามิก

        // ตำแหน่งของเหรียญ
        getCoin.transform.position = new Vector2(
            transform.position.x - getCoin.Speed * Time.deltaTime,
            Mathf.Sin(Time.time) * 2 // ขึ้นลง
        );
    }
}
