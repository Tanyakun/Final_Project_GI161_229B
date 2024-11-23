using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhino : Enemy
{
    void Start()
    {
        Speed = 5f; // กำหนดค่า speed ผ่าน Property
        Move();
    }

    protected override void Move()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }

    protected override void OnCollideWithPlayer()
    {
        Debug.Log("Player hit by Rhino! Game Over.");
        GameManager.Instance.GameOver();
    }
    /*public void Init() 
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
    }*/
}
