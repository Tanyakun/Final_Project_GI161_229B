using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Player : Character
{
    public void Init()
    {
        Health = 100;
    }
    private void Start()
    {
        Init();
        IsDead();
    }
}
