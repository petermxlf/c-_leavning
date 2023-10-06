using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlogic : MonoBehaviour
{
    [Tooltip("子弹节点的预制体")]
    public GameObject bulletprefab;
    [Tooltip("子弹节点的父节点")]
    public Transform bulletfolder;
    [Tooltip("子弹出生点")]
    public Transform firepoint;
    [Tooltip("开火间隔")]
    public float fireinterval = 0.1f;
    [Tooltip("平移速度")]
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
        if (Input.GetKey(KeyCode.A))//判断是否按下按键，可长按执行
        {
            dx = -movespeed;//向左移动
        }
        if (Input.GetKey(KeyCode.D))
        {
            dx = movespeed;//向右移动
        }
        this.transform.Translate(dx, 0, 0, Space.Self);
    }
    private void Fire()
    {
        GameObject node = Instantiate(bulletprefab, bulletfolder);//实例化一个子弹节点
        node.transform.position = firepoint.position;//把子弹挪到指定的坐标
    }
}
