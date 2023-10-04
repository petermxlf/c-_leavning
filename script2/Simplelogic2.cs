using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

//unity 是单线程
public class Simplelogic2 : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        //定时调用
        Debug.Log("* Start . . ."+ Time.time);
        //this.Invoke("DoSomething", 1);//一秒钟后调用DoSomething函数
        this.InvokeRepeating("DoSomething", 1, 2);//一秒钟后调用第一次，之后每隔两秒调用一次

        //线程：Thread.CurrentThread.ManagedThreadId
        Debug.Log("* start.线程ID" + Thread.CurrentThread.ManagedThreadId);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, speed * Time.deltaTime, 0, Space.Self);

        Debug.Log("* update.线程ID" + Thread.CurrentThread.ManagedThreadId);

    }
    private void DoSomething()
    {
        Debug.Log("* dosomething . . ." + Time.time);
        this.speed =0-speed;

        Debug.Log("* dosomething.线程ID" + Thread.CurrentThread.ManagedThreadId);

    }
}
