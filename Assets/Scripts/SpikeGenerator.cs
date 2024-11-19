using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    // ��С�������� object �������ʻ͹��觡�մ���ҧ
    public GameObject spike;

    // ��������������鹵͹�������
    public float Minspeed;

    // ������������ش�ͧ��觡�մ���ҧ
    public float MaxSpeed;

    // �������ǻѨ�غѹ
    public float currentSpeed;

    // �Դ�������Ƿ�������������������������
    public float SpeedMultiplier;

    // set ���������Ƿ���������ҡѺ�������ǻѨغѹ�͹�������
	private void Awake()
	{
        currentSpeed = Minspeed;
        generateSpike();
	}

    // �к� Random ������Թ��ҹ NextLine Tag ���Դ��Ҩл���������ͻ���ª��
    public void GenerateNextSpikeWihtGap()
    {
        float randomWait = Random.Range(1.0f, 1.2f);
        Invoke("generateSpike", randomWait);
    }

    // ��С����� Object �����ӹǹ���� copy �͡���������
    public void generateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);

        SpikeIns.GetComponent<SpikeScript>().spikeGenerator = this;
    }

    // ���������ǻѨ�غѹ ����Թ���������٧�ش �¤������ǻѨ�غѹ��������ҵ���������� Multiplier
	void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
