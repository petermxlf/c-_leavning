using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylogic2 : MonoBehaviour
{
    [Tooltip("移动速度")]
    public float speed = 10;
    [Tooltip("玩家预制体")]
    public GameObject player;
    [Tooltip("引用子弹预制体")]
    public GameObject bullet;
    [Tooltip("引用子弹的父节点")]
    public Transform bullettime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("testfire", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 p1 = player.transform.position;
        Vector3 p2 = this.transform.position;
        float distance = Vector3.Distance(p1, p2);
        this.transform.Translate(0, 0, speed * Time.deltaTime,Space.Self);//移动
        this.transform.LookAt(player.transform.position);//看向玩家
    }
    private void testfire()
    {

        GameObject node = Instantiate(bullet, bullettime);
        node.transform.position = bullettime.transform.position;
    }
}
