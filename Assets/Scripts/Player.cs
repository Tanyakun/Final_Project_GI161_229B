using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore.Text;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Player : MonoBehaviour
{
    // Attributes
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    int coin = 0;
    public int Coin => coin;
    [SerializeField] TextMeshProUGUI coinPointTxT;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UpdateCoinText();
    }

    // Method เช็คว่าผู้เล่นชน Enemy หรือยัง ถ้าชน = เกมจบ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.GameOver();
        }
    }

    // Method เก็บค่าเหรียญ + Text แสดงจำนวนคะแนนเหรียญ
    public void GetCoin(int coinIncrease)
    {
        coin += coinIncrease;
        Debug.Log($"Coin increased by {coinIncrease}. New Coin: {coin}");
        UpdateCoinText();
    }

    // Method Text Coin On Game Screen
    void UpdateCoinText()
    {
        coinPointTxT.text = $"Coin: {Coin}";
    }
}
