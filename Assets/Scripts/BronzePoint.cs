using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronzePoint : GetCoin
{
    public int coinIncrease;

    void Start()
    {
        coinIncrease = 5;
    }

    public override void ApplyCoin(Player player)
    {
        player.GetCoin(coinIncrease);
    }
}
