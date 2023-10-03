using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlogic : MonoBehaviour
{
    int m_index = 0;//表示显示的是哪一个形状
    float speed = 1;//规定速度
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Changshape();
        }
        this.transform.Translate(0, 0, speed * Time.deltaTime, Space.Self);//移动
    }
    private void Changshape()
    {
        //先把原来的形状隐藏
        this.transform.GetChild(m_index).gameObject.SetActive(false);//获取子物体，再把子物体隐藏

        m_index += 1;
        int count = this.transform.childCount;
        if (m_index >= count)
            m_index = 0;

        //显示新的物体
        this.transform.GetChild(m_index).gameObject.SetActive(true);//获取子物体，显示子物体
    }
}
