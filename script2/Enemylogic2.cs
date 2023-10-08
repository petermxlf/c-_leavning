using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylogic2 : MonoBehaviour
{
    [Tooltip("�ƶ��ٶ�")]
    public float speed = 10;
    [Tooltip("���Ԥ����")]
    public GameObject player;
    [Tooltip("�����ӵ�Ԥ����")]
    public GameObject bullet;
    [Tooltip("�����ӵ��ĸ��ڵ�")]
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
        this.transform.Translate(0, 0, speed * Time.deltaTime,Space.Self);//�ƶ�
        this.transform.LookAt(player.transform.position);//�������
    }
    private void testfire()
    {

        GameObject node = Instantiate(bullet, bullettime);
        node.transform.position = bullettime.transform.position;
    }
}
