using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTin : Enemy
{
    public void Init()
    {
        Damage = 25;
    }
    private void Start()
    {
        Init();
    }

    public override void Attack(Character character)
    {
        if (character is Player)
            character.TakeDamage(this.Damage);
    }
}
