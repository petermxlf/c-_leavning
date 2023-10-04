using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//向量
//标准向量，向量的长度为1
//向量的计算：x^2+y^2+z^2开根号

//Vector3.zero=(0,0,0)
//Vector3.up=(0,1,0)
//Vector3.right(1,0,0)
//Vector3.forward(0,0,1)
public class SimpleLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 v = new Vector3(3, 0, 4);
        //float len = v.magnitude;//向量长度
        //Debug.Log("* 结果" + len);

        Vector3 v1 = new Vector3(2, 2, 0);
        Vector3 v2 = v1.normalized;//标准化
        Debug.Log("* 结果" + v2.ToString("f3"));//保留三位小数

        //Vector3 v1 = Vector3.zero;

        Vector3 a = new Vector3(1, 3, 0);
        Vector3 b = new Vector3(4,1,3);
        Vector3 c = a + b;
        Debug.Log("* c=：" + c);
        c = a * 2;//坐标放大二倍
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
