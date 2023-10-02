using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplelogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("** 开始测试>");
        /*GameObject obj=this.gameObject;
        string name = obj.name;
        Debug.Log("** 物体名字:" + this.gameObject.name);
        Transform tr = this.gameObject.transform;
        Vector3 pos=this.transform.localPosition;
        Debug.Log("** 物品的位置：" + pos.ToString("F3"));*/
        //this.transform.localPosition = new Vector3(0,2.5f,0);
    }
    //transform.position世界坐標
    //transfor.localPosition本地坐標
    //this.gameObject.transform.position-->this.transform.position
    //Vector3類型，即三維向量，含x,y,x三個分量(float)


    // Update is called once per frame
    void Update()//帧更新
    {
        //利用deltaTime让物品匀速运动
        float speed = 3;
        float distance = speed * Time.deltaTime;//以3米每秒的速度匀速移动
        Debug.Log("** 帧更新  时间差 =" + Time.deltaTime);
        Vector3 pos = this.transform.localPosition;//获取当前物体坐标
        pos.x += distance;//将当前x轴增加
        this.transform.localPosition = pos;//变更当前物体位置

    }
    //Time.time游戏时间
    //Time.deltaTime距上次更新的时间差
    //Application.targetFrameRate=帧率  unity不支持固定帧率，但可以设置近似帧率
    //this.transform.Translate(dx,dy,dz，space);物体移动方法，dx,dy,dz代表下一个位置的坐标
    //Space.World相对与世界坐标移动,东西南北
    //Space.Self相对与自身坐标移动，前后左右
}
