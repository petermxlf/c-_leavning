using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainlogic : MonoBehaviour
{
    //引用类型参数
    [Tooltip("目标物体")]
    public GameObject target;//目标物体
    [Tooltip("移动速度")]
    public float speed=2;//移动速度
    // Start is called before the first frame update
    void Start()
    {
        this.transform.LookAt(target.transform);//转向
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p1 = this.transform.position;
        Vector3 p2 = target.transform.position;
        Vector3 p = p2 - p1;
        float distance = p.magnitude;
        if (distance > 1.5f)
        {
            float move = speed * Time.deltaTime;
            this.transform.Translate(0, 0, move, Space.Self);
        }
    }
}
