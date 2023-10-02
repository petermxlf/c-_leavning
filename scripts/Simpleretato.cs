using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simpleretato : MonoBehaviour
{
    public float rotateSpeed = -90f;

    public int intValue = 0;
    public float floatValue = 0.5f;
    public bool boolValue = true;
    public string stringValue = "小白你好";
    public Vector3 rotatoSpeed;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        //欧拉角
        //transform.eulerAngles = new Vector3(90, 0, 45);//在z轴方向旋转，世界坐标
        //transform.localEulerAngles = new Vector3(90, 0, 45);//在z轴方向旋转,本地坐标
    }

    // Update is called once per frame
    void Update()
    {
        //float rotateSpeed = -90;//每秒转90度,角速度
        //Vector3 angles = this.transform.localEulerAngles;//获取当前转角
        //angles.z += rotateSpeed*Time.deltaTime;//度数=秒/转*时间差
        //transform.localEulerAngles = angles;//转向新度数

        //相对旋转
        this.transform.Rotate(0,0 , rotateSpeed * Time.deltaTime, Space.Self);//依照自身角度旋转，球
        //this.transform.Rotate(0,0 , rotateSpeed * Time.deltaTime, Space.Self);//依照自身角度旋转,风扇

    }
    //自转；绕着自身轴旋转
    //公转；绕着另一个物体旋转(父物体)
}
