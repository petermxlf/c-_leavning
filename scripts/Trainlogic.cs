using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainlogic : MonoBehaviour
{
    //�������Ͳ���
    [Tooltip("Ŀ������")]
    public GameObject target;//Ŀ������
    [Tooltip("�ƶ��ٶ�")]
    public float speed=2;//�ƶ��ٶ�
    // Start is called before the first frame update
    void Start()
    {
        this.transform.LookAt(target.transform);//ת��
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p1 = this.transform.position;
        Vector3 p2 = target.transform.position;
        Vector3 p = p2 - p1;
        float distance = p.magnitude;
        if (distance > 1.5f)
        {
            float move = speed * Time.deltaTime;
            this.transform.Translate(0, 0, move, Space.Self);
        }
    }
}
