using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // เช็คว่าชนกับ Player หรือยัง
        {
            Player player = other.GetComponent<Player>();
            GetCoin getCoin = GetComponent<GetCoin>();

            if (getCoin != null && player != null)
            {
                getCoin.ApplyCoin(player);
                Destroy(gameObject);
            }
        }
        else if (other.CompareTag("Finish")) // เช็คว่าชนกับเส้น FinishLine หรือยัง
        {
            {
                Destroy(gameObject);
            }
        }
    }
}
