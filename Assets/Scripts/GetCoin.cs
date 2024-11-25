using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GetCoin : MonoBehaviour
{
    protected float speed; // Encapsulation: ซ่อนค่า speed และกำหนดผ่าน Property

    public float Speed // ความเร็วของเหรียญ
    {
        get { return speed; }
        set { speed = Mathf.Clamp(value, 1f, 10f); } // จำกัดค่า speed ไม่ให้เกิน 10
    }

    void Update()
    {
        // เคลื่อนที่ไปทางซ้ายตลอดเวลา
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }

    public abstract void ApplyCoin(Player player);
}
