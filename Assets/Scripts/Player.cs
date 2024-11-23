using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore.Text;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Player : MonoBehaviour
{
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.GameOver();
        }
    }

    public void GetCoin(int coinIncrease)
    {
        coin += coinIncrease;
        Debug.Log($"Coin increased by {coinIncrease}. New Coin: {coin}");
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        coinPointTxT.text = $"Coin: {Coin}";
    }
}
