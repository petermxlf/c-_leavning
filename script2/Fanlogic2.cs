using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanlogic2 : MonoBehaviour
{
    public float maxRotatespeed = 720;//�������ת��
    float m_speed = 0;//��ǰת��
    bool m_speedup = false;//true���٣�false����
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AdjustSpeed", 0.1f, 0.1f);//ÿ0.1s����һ��
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//��һ�¼��٣��ٵ�һ�¼���
        {
            m_speedup = !m_speedup;
        }
        //��ת
        if (m_speed > 0)
        {
            this.transform.Rotate(m_speed * Time.deltaTime, 0, 0, Space.Self);
        }
    }
    private void AdjustSpeed()
    {
        if (m_speedup)
        {
            if (m_speed < maxRotatespeed)
                m_speed += 10;
        }
        else
        {
            m_speed -= 10;
            if (m_speed < 0)
                m_speed = 0;
        }
    }
}
