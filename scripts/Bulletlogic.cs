using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletlogic : MonoBehaviour
{
    [Tooltip("子弹飞行速度")]
    public float speed=50;
    //public GameObject enumy;//应用敌人预制体
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroys", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed*Time.deltaTime, Space.Self);
    }
    private void Destroys()
    {
        Object.Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider enumy)
    {
        Debug.Log("* 击中other= " + enumy.name);
        if (!enumy.name.StartsWith("球")) return;
        Destroy(this.gameObject);//销毁自己
        Destroy(enumy.gameObject);//销毁对方
    }
}
