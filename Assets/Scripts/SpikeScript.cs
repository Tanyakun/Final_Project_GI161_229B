using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    // ���¡ SpikeGenerator
    public SpikeGenerator spikeGenerator;

    // ����� Object ����͹���仴�ҹ˹��
    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.currentSpeed * Time.deltaTime);
    }

    // ������������ Object ��ҹ NextLine Object �� spwan �ա���� �����Թ件֧ Finish ��� Object �١�����
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
