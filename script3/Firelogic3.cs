using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//使用空物体标记空间坐标
public class Firelogic3 : MonoBehaviour
{
    public GameObject bulletprefab;//节点类型变量

    public Transform bullefolder;//组件引用

    public Transform firepoint;//设置出生点

    public Transform cannon;//引用炮塔

    public float bulletspeed;//飞行速度

    public float bulletlifetime;//飞行时长
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Testfire();
        }
    }
    private void Testfire()
    {
        Debug.Log("* 创建子弹的实例 . .");
        //预制体实例化，并创建新的节点
        GameObject node = Object.Instantiate(bulletprefab, bullefolder);//将新创建的实例放在bullefolder父节点下
        node.transform.position =this.firepoint.position;//把节点放在出生点,因为二者不在同一个父节点下边所以使用世界坐标更准确
        //node.transform.localEulerAngles = Vector3.zero;
        node.transform.eulerAngles = this.cannon.eulerAngles;//欧拉角对其子弹与炮口角度

        Bulletlogic3 buli = node.GetComponent<Bulletlogic3>();
        buli.speed = this.bulletspeed;//飞行时长

        buli.maxdistance = buli.speed * this.bulletlifetime;//最大飞行距离
        //node.transform.rotation = this.cannon.rotation;//四元数对其子弹与炮口角度
    }// Start is called before the first frame update
}
