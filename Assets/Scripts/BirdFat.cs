using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFat : Enemy
{
    public void Init()
    {
        Damage = 50;
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
