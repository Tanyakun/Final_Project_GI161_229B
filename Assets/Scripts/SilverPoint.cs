using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverPoint : GetCoin
{
    public int coinIncrease;

    void Start()
    {
        coinIncrease = 10;
    }

    public override void ApplyCoin(Player player)
    {
        player.GetCoin(coinIncrease);
    }
}
