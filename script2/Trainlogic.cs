using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������
//�����ľ��룬ȷ��˵�������������ĵ�֮��ľ���
//����������֮�����ʱ���ȷ�����������ĵ�λ���Ƿ���ͬһƽ��,��Ȼ�������
public class Trainlogic : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject target = GameObject.Find("����");
        Vector3 p1 = this.transform.position;
        Vector3 p2 = target.transform.position;
        //����ԭ�㵽���ӵľ����ȥ����ԭ�㵽���������������֮�����,�����ļ���
        //Vector3 direction = p2 - p1;//������֮�����
        //float distance = direction.magnitude;
        float distance = Vector3.Distance(p2, p1);//Distance����
        Debug.Log("* ���룺" + distance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
