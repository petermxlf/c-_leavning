using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//子弹运行
public class Bulletlogic3 : MonoBehaviour
{
    public float speed;//飞行速度

    public float maxdistance;//最大飞行距离

    // Start is called before the first frame update
    void Start()
    {
        float lifetime = 1;
        if (speed > 0)
        {
            lifetime = maxdistance / speed;
        }
        //Invoke("selfdestroy", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed, Space.Self);
    }
    private void selfdestroy()
    {
        Debug.Log("* 自毁 . .");
        Object.Destroy(this.gameObject);//销毁当前预制体实例
    }
}
