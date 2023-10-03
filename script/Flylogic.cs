using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flylogic : MonoBehaviour
{
    float m_speed = 0;
    // Start is called before the first frame update
    //public GameObject node;//获取物体,建议使用

    void Start()
    {
        //GameObject node = GameObject.Find("物体名字或指定路径");//获取物体
        //Transform parent = this.transform.parent;//获取父级
        //GameObject parentNode = this.transform.parent.gameObject;//获取父级节点
        //Debug.Log("** 父级：" + parent.name);//打印父级名字

        foreach(Transform child in transform)//获取子物体
        {
            Debug.Log("* 子物体：" + child.name);//子物体名字
        }
        Transform tran = this.transform.GetChild(0);//获取第零个子节点
        Debug.Log("* 子物体：" + tran.name);//子物体名字
        //Transform child = this.transform.Find("");//利用find方法获取子物体


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
            Test();//设置新的父级
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
        //this.transform.SetParent(null);//传入空值，设为一级节点
        Transform child = this.transform.Find("Cube");
        if (child.gameObject.activeSelf)//判断是否是显示状态
        {
            child.gameObject.SetActive(false);//设置为隐藏
        }
        else
        {
            child.gameObject.SetActive(true);//设置为显示

        }
    }
}
