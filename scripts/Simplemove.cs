using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplemove : MonoBehaviour
{
    GameObject flag;
    // Start is called before the first frame update
    void Start()//ֻ����һ��
    {
        flag = GameObject.Find("Ŀ��");//��ȡĿ��λ��
        this.transform.LookAt(flag.transform);//ת��Ŀ��


        //Debug.Log("** ������֮��ľ����ǣ�"+ distance);
    }
    //����Ŀ��������ͬ��һƽ����ʱʹ��LookAt
    //lookat�����ı׶ˣ���ʹĿ��λ���ڿ��У�lookat���ɻ�ת��Ŀ�꣬��ʱ����Ŀ���ƶ��������

    // Update is called once per frame
    void Update()//ѭ������
    {
        Vector3 p1 = this.transform.position;
        Vector3 p2 = flag.transform.position;
        Vector3 p = p2 - p1;
        float distance = p.magnitude;
        if (distance > 1.5f)
        {
            float speed = 1.5f;
            float distance1 = speed * Time.deltaTime;

            //Vector3 pos = this.transform.localPosition;
            //pos.z += distance;
            //this.transform.localPosition = pos;

            //this.transform.Translate(0, 0, distance,Space.World);//��z�����ƶ�,��������������ƶ�
            //this.transform.Translate(0, 0, distance,Space.Self);//��z�����ƶ�,������������������ƶ�

            this.transform.Translate(0, 0, distance1, Space.Self);//��Ŀ���ƶ�
        }

        

    }
    //GameObject.Find(name_or_path),��������/·������������
    //    ������/������/������

}
