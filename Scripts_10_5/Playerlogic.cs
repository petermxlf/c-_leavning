using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlogic : MonoBehaviour
{
    [Tooltip("�ӵ��ڵ��Ԥ����")]
    public GameObject bulletprefab;
    [Tooltip("�ӵ��ڵ�ĸ��ڵ�")]
    public Transform bulletfolder;
    [Tooltip("�ӵ�������")]
    public Transform firepoint;
    [Tooltip("������")]
    public float fireinterval = 0.1f;
    [Tooltip("ƽ���ٶ�")]
    public float movespeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", fireinterval, fireinterval);
    }

    // Update is called once per frame
    void Update()
    {
        float dx = 0;
        if (Input.GetKey(KeyCode.A))//�ж��Ƿ��°������ɳ���ִ��
        {
            dx = -movespeed;//�����ƶ�
        }
        if (Input.GetKey(KeyCode.D))
        {
            dx = movespeed;//�����ƶ�
        }
        this.transform.Translate(dx, 0, 0, Space.Self);
    }
    private void Fire()
    {
        GameObject node = Instantiate(bulletprefab, bulletfolder);//ʵ����һ���ӵ��ڵ�
        node.transform.position = firepoint.position;//���ӵ�Ų��ָ��������
    }
}
