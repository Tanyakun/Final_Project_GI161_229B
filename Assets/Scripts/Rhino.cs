using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhino : Enemy
{
    public void Init() 
    {
        Damage = 100;
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
