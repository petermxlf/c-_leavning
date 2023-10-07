using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    public float speed = 10f;//移动速度
    public GameObject enumy;//引用主角
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p1 = enumy.transform.position;
        Vector3 p2 = this.transform.position;
        float distance = Vector3.Distance(p1,p2);
        this.transform.LookAt(enumy.transform);
        if (distance>20f)
            this.transform.Translate(p1*Time.deltaTime, Space.Self);
    }
}
