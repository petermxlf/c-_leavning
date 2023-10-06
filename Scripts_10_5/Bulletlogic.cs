using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletlogic : MonoBehaviour
{
    [Tooltip("子弹飞行速度")]
    public float speed = 1;
    [Tooltip("子弹生命时长")]
    public float lifetime = 3;
    [Tooltip("粒子特效")]
    public GameObject explosionEffe;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestroy", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed*Time.deltaTime, Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("* 子弹碰撞 other= " + other.name);

        if (!other.name.StartsWith("怪兽")) return;//检查对方的名字是否是怪兽开头,如果不是不执行后面的语句

        Destroy(this.gameObject);//销毁自己
        Destroy(other.gameObject);//销毁对方

        //创建一个粒子特效
        //GameObject effectnode = Instantiate(explosionEffe, null);
        //effectnode.transform.position = this.transform.position;
        //当粒子特效播放完之后会自己销毁
    }
    private void SelfDestroy()
    {
        Object.Destroy(this.gameObject);
    }
}
