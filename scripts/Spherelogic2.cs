using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spherelogic2 : MonoBehaviour
{
    public Material[] colors;

    int m_index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            changecolor();
        }
    }
    private void changecolor()
    {
        m_index += 1;
        if (m_index >= this.colors.Length)
        {
            m_index = 0;
        }
        Material selected = this.colors[m_index];//�����������ͱ�����ָ�����

        MeshRenderer rd = GetComponent<MeshRenderer>();//��ȡ�������
        rd.material = selected;
    }
}
