using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simpleretato : MonoBehaviour
{
    public float rotateSpeed = -90f;

    public int intValue = 0;
    public float floatValue = 0.5f;
    public bool boolValue = true;
    public string stringValue = "С�����";
    public Vector3 rotatoSpeed;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        //ŷ����
        //transform.eulerAngles = new Vector3(90, 0, 45);//��z�᷽����ת����������
        //transform.localEulerAngles = new Vector3(90, 0, 45);//��z�᷽����ת,��������
    }

    // Update is called once per frame
    void Update()
    {
        //float rotateSpeed = -90;//ÿ��ת90��,���ٶ�
        //Vector3 angles = this.transform.localEulerAngles;//��ȡ��ǰת��
        //angles.z += rotateSpeed*Time.deltaTime;//����=��/ת*ʱ���
        //transform.localEulerAngles = angles;//ת���¶���

        //�����ת
        this.transform.Rotate(0,0 , rotateSpeed * Time.deltaTime, Space.Self);//��������Ƕ���ת����
        //this.transform.Rotate(0,0 , rotateSpeed * Time.deltaTime, Space.Self);//��������Ƕ���ת,����

    }
    //��ת��������������ת
    //��ת��������һ��������ת(������)
}
