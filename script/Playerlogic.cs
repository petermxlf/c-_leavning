using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlogic : MonoBehaviour
{
    int m_index = 0;//��ʾ��ʾ������һ����״
    float speed = 1;//�涨�ٶ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Changshape();
        }
        this.transform.Translate(0, 0, speed * Time.deltaTime, Space.Self);//�ƶ�
    }
    private void Changshape()
    {
        //�Ȱ�ԭ������״����
        this.transform.GetChild(m_index).gameObject.SetActive(false);//��ȡ�����壬�ٰ�����������

        m_index += 1;
        int count = this.transform.childCount;
        if (m_index >= count)
            m_index = 0;

        //��ʾ�µ�����
        this.transform.GetChild(m_index).gameObject.SetActive(true);//��ȡ�����壬��ʾ������
    }
}
