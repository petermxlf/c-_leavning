using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplelogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("** ��ʼ����>");
        /*GameObject obj=this.gameObject;
        string name = obj.name;
        Debug.Log("** ��������:" + this.gameObject.name);
        Transform tr = this.gameObject.transform;
        Vector3 pos=this.transform.localPosition;
        Debug.Log("** ��Ʒ��λ�ã�" + pos.ToString("F3"));*/
        //this.transform.localPosition = new Vector3(0,2.5f,0);
    }
    //transform.position��������
    //transfor.localPosition��������
    //this.gameObject.transform.position-->this.transform.position
    //Vector3��ͣ������S��������x,y,x��������(float)


    // Update is called once per frame
    void Update()//֡����
    {
        //����deltaTime����Ʒ�����˶�
        float speed = 3;
        float distance = speed * Time.deltaTime;//��3��ÿ����ٶ������ƶ�
        Debug.Log("** ֡����  ʱ��� =" + Time.deltaTime);
        Vector3 pos = this.transform.localPosition;//��ȡ��ǰ��������
        pos.x += distance;//����ǰx������
        this.transform.localPosition = pos;//�����ǰ����λ��

    }
    //Time.time��Ϸʱ��
    //Time.deltaTime���ϴθ��µ�ʱ���
    //Application.targetFrameRate=֡��  unity��֧�̶ֹ�֡�ʣ����������ý���֡��
    //this.transform.Translate(dx,dy,dz��space);�����ƶ�������dx,dy,dz������һ��λ�õ�����
    //Space.World��������������ƶ�,�����ϱ�
    //Space.Self��������������ƶ���ǰ������
}
