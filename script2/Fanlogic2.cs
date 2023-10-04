using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanlogic2 : MonoBehaviour
{
    public float maxRotatespeed = 720;//设置最大转速
    float m_speed = 0;//当前转速
    bool m_speedup = false;//true加速，false减速
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AdjustSpeed", 0.1f, 0.1f);//每0.1s调用一次
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//点一下加速，再点一下减速
        {
            m_speedup = !m_speedup;
        }
        //旋转
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
