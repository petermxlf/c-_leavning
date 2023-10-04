using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubelogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (IsInvoking("Expand"))
            {
                CancelInvoke("Expand");//停止调用
            }
            else
            {
                InvokeRepeating("Expand", 1, 1);
            }
            //若不小心进行了两次定时调用，那么两次调用都会生效并且是独立的
            //InvokeRepeating("Expand", 1, 1);

            //InvokeRepeating("Expand", 1, 1);
        }
    }
    private void Expand()
    {
        Debug.Log("* 变长  . ." + Time.time);

        Vector3 scale = this.transform.localScale;
        scale.y += 1;
        this.transform.localScale = scale;
    }
}
