using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ʹ�ÿ������ǿռ�����
public class Firelogic3 : MonoBehaviour
{
    public GameObject bulletprefab;//�ڵ����ͱ���

    public Transform bullefolder;//�������

    public Transform firepoint;//���ó�����

    public Transform cannon;//��������

    public float bulletspeed;//�����ٶ�

    public float bulletlifetime;//����ʱ��
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Testfire();
        }
    }
    private void Testfire()
    {
        Debug.Log("* �����ӵ���ʵ�� . .");
        //Ԥ����ʵ�������������µĽڵ�
        GameObject node = Object.Instantiate(bulletprefab, bullefolder);//���´�����ʵ������bullefolder���ڵ���
        node.transform.position =this.firepoint.position;//�ѽڵ���ڳ�����,��Ϊ���߲���ͬһ�����ڵ��±�����ʹ�����������׼ȷ
        //node.transform.localEulerAngles = Vector3.zero;
        node.transform.eulerAngles = this.cannon.eulerAngles;//ŷ���Ƕ����ӵ����ڿڽǶ�

        Bulletlogic3 buli = node.GetComponent<Bulletlogic3>();
        buli.speed = this.bulletspeed;//����ʱ��

        buli.maxdistance = buli.speed * this.bulletlifetime;//�����о���
        //node.transform.rotation = this.cannon.rotation;//��Ԫ�������ӵ����ڿڽǶ�
    }// Start is called before the first frame update
}
