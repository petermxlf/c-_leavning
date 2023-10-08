using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletlogic2 : MonoBehaviour
{
    [Tooltip("子弹飞行速度")]
    public float speed = 30f;
    [Tooltip("子弹生命周期")]
    public float firetime = 3f;
    int count=0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("testDestroy", firetime);//生命周期
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed * Time.deltaTime,Space.Self);
    }
    private void testDestroy()
    {
        Destroy(this.gameObject);//销毁子弹
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.name.StartsWith("敌人")) return;
        Debug.Log("** 击中*" + count);
        count++;
        Destroy(this.gameObject);
        Destroy(other.gameObject);
    }
}
