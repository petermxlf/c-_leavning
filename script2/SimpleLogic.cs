using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//����
//��׼�����������ĳ���Ϊ1
//�����ļ��㣺x^2+y^2+z^2������

//Vector3.zero=(0,0,0)
//Vector3.up=(0,1,0)
//Vector3.right(1,0,0)
//Vector3.forward(0,0,1)
public class SimpleLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 v = new Vector3(3, 0, 4);
        //float len = v.magnitude;//��������
        //Debug.Log("* ���" + len);

        Vector3 v1 = new Vector3(2, 2, 0);
        Vector3 v2 = v1.normalized;//��׼��
        Debug.Log("* ���" + v2.ToString("f3"));//������λС��

        //Vector3 v1 = Vector3.zero;

        Vector3 a = new Vector3(1, 3, 0);
        Vector3 b = new Vector3(4,1,3);
        Vector3 c = a + b;
        Debug.Log("* c=��" + c);
        c = a * 2;//����Ŵ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
