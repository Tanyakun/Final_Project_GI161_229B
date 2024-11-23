using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPoint : GetCoin
{
    public int coinIncrease;

    void Start()
    {
        coinIncrease = 20;
    }

    public override void ApplyCoin(Player player)
    {
        player.GetCoin(coinIncrease);
    }
}
