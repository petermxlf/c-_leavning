using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

//unity �ǵ��߳�
public class Simplelogic2 : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        //��ʱ����
        Debug.Log("* Start . . ."+ Time.time);
        //this.Invoke("DoSomething", 1);//һ���Ӻ����DoSomething����
        this.InvokeRepeating("DoSomething", 1, 2);//һ���Ӻ���õ�һ�Σ�֮��ÿ���������һ��

        //�̣߳�Thread.CurrentThread.ManagedThreadId
        Debug.Log("* start.�߳�ID" + Thread.CurrentThread.ManagedThreadId);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, speed * Time.deltaTime, 0, Space.Self);

        Debug.Log("* update.�߳�ID" + Thread.CurrentThread.ManagedThreadId);

    }
    private void DoSomething()
    {
        Debug.Log("* dosomething . . ." + Time.time);
        this.speed =0-speed;

        Debug.Log("* dosomething.�߳�ID" + Thread.CurrentThread.ManagedThreadId);

    }
}
