using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplesun : MonoBehaviour
{
    [ Tooltip("���ٶ�")]
    public float rotateSpeed = 30f;
    void Awake()
    {
        Debug.Log("** Awake()��ʼ��");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("** Start()��ʼ��");

    }

    // Update is called once per frame
    void Update()
    {
        //��Ը�������ת
        //float rotateSpeed = 60;
        Transform parent = this.transform.parent;
        parent.Rotate(0, rotateSpeed*Time.deltaTime, 0, Space.Self);
    }
    void OnEnable()
    {
        //Debug.Log("** OnEnable() �������");

    }
    void OnDisable()
    {
        //Debug.Log("** OnDisable() �������");

    }
    //OnEnableÿ���������ʱ����
    //OnDisableÿ���������ʱ����
}
