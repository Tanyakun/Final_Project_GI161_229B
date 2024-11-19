using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    // เรียก SpikeGenerator
    public SpikeGenerator spikeGenerator;

    // ทำให้ Object เคลื่อนที่ไปด้านหน้า
    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.currentSpeed * Time.deltaTime);
    }

    // เพิ่มให้เมื่อ Object ผ่าน NextLine Object จะ spwan อีกครั้ง แต่ถ้าเดินไปถึง Finish ให้ Object ถูกทำลาย
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.CompareTag("NextLine"))
        {
            spikeGenerator.GenerateNextSpikeWihtGap();
        }

		if (collision.gameObject.CompareTag("Finish"))
		{
            Destroy(this.gameObject);
		}
	}
}
