using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//向量测距
//物体间的距离，确切说就是两物体轴心点之间的距离
//再求两物体之间距离时最好确定两物体轴心点位置是否在同一平面,不然会有误差
public class Trainlogic : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject target = GameObject.Find("棋子");
        Vector3 p1 = this.transform.position;
        Vector3 p2 = target.transform.position;
        //世界原点到棋子的距离减去世界原点到本物体就是两物体之间距离,向量的减法
        //Vector3 direction = p2 - p1;//两物体之间距离
        //float distance = direction.magnitude;
        float distance = Vector3.Distance(p2, p1);//Distance函数
        Debug.Log("* 距离：" + distance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
