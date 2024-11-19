using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    // ประกาศให้เอา object ใส่เพื่อสปอนสิ่งกรีดขว้าง
    public GameObject spike;

    // ความเร็วเริ่มต้นตอนเริ่มเกม
    public float Minspeed;

    // ความเร็วไว้สุดของสิ่งกรีดขว้าง
    public float MaxSpeed;

    // ความเร็วปัจจุบัน
    public float currentSpeed;

    // คิดความเร็วที่ที่เพิ่มขึ้นว่าเพิ่มเท่าไหร่
    public float SpeedMultiplier;

    // set ให้ความเร็วที่เริ่มเท่ากับความเร็วปัจุบันตอนเริ่มเกม
	private void Awake()
	{
        currentSpeed = Minspeed;
        generateSpike();
	}

    // ระบบ Random เมื่อเดินผ่าน NextLine Tag ให้คิดว่าจะปล่อยไวหรือปล่อยช้า
    public void GenerateNextSpikeWihtGap()
    {
        float randomWait = Random.Range(1.0f, 1.2f);
        Invoke("generateSpike", randomWait);
    }

    // ประกาศให้ Object เพิ่มจำนวนหรือ copy ออกมาเลื่อยๆ
    public void generateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);

        SpikeIns.GetComponent<SpikeScript>().spikeGenerator = this;
    }

    // ให้ความเร็วปัจจุบัน ไม่เกินความเร็วสูงสุด โดยความเร็วปัจจุบันจะเพิ่มค่าตามความเร็ว Multiplier
	void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
