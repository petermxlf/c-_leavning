using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flylogic : MonoBehaviour
{
    float m_speed = 0;
    // Start is called before the first frame update
    //public GameObject node;//��ȡ����,����ʹ��

    void Start()
    {
        //GameObject node = GameObject.Find("�������ֻ�ָ��·��");//��ȡ����
        //Transform parent = this.transform.parent;//��ȡ����
        //GameObject parentNode = this.transform.parent.gameObject;//��ȡ�����ڵ�
        //Debug.Log("** ������" + parent.name);//��ӡ��������

        foreach(Transform child in transform)//��ȡ������
        {
            Debug.Log("* �����壺" + child.name);//����������
        }
        Transform tran = this.transform.GetChild(0);//��ȡ������ӽڵ�
        Debug.Log("* �����壺" + tran.name);//����������
        //Transform child = this.transform.Find("");//����find������ȡ������


    }

    // Update is called once per frame
    void Update()
    {
        float height = this.transform.position.y;
        float dy = m_speed * Time.deltaTime;
        if (dy > 0 && height < 4)
        {
            this.transform.Translate(0, dy, 0, Space.Self);
        }
        if (dy < 0 && height > 0)
        {
            this.transform.Translate(0, dy, 0, Space.Self);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Test();//�����µĸ���
        }


    }
    public void Fly()
    {
        m_speed = 1;
    }
    public void Land()
    {
        m_speed = -1;
    }
    private void Test()
    {
        Transform node = this.transform.Find("/Sphere2");
        this.transform.SetParent(node);
        //this.transform.SetParent(null);//�����ֵ����Ϊһ���ڵ�
        Transform child = this.transform.Find("Cube");
        if (child.gameObject.activeSelf)//�ж��Ƿ�����ʾ״̬
        {
            child.gameObject.SetActive(false);//����Ϊ����
        }
        else
        {
            child.gameObject.SetActive(true);//����Ϊ��ʾ

        }
    }
}
