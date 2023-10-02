using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplemove : MonoBehaviour
{
    GameObject flag;
    // Start is called before the first frame update
    void Start()//只运行一次
    {
        flag = GameObject.Find("目标");//获取目标位置
        this.transform.LookAt(flag.transform);//转向目标


        //Debug.Log("** 两物体之间的距离是："+ distance);
    }
    //建议目标与自身同在一平面上时使用LookAt
    //lookat方法的弊端，即使目标位置在空中，lookat依旧会转向目标，这时若向目标移动会出问题

    // Update is called once per frame
    void Update()//循环运行
    {
        Vector3 p1 = this.transform.position;
        Vector3 p2 = flag.transform.position;
        Vector3 p = p2 - p1;
        float distance = p.magnitude;
        if (distance > 1.5f)
        {
            float speed = 1.5f;
            float distance1 = speed * Time.deltaTime;

            //Vector3 pos = this.transform.localPosition;
            //pos.z += distance;
            //this.transform.localPosition = pos;

            //this.transform.Translate(0, 0, distance,Space.World);//向z方向移动,相对于世界坐标移动
            //this.transform.Translate(0, 0, distance,Space.Self);//向z方向移动,相对于物体自身坐标移动

            this.transform.Translate(0, 0, distance1, Space.Self);//朝目标移动
        }

        

    }
    //GameObject.Find(name_or_path),根据名字/路径来查找物体
    //    父物体/子物体/孙物体

}
