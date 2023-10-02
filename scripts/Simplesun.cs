using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplesun : MonoBehaviour
{
    [ Tooltip("角速度")]
    public float rotateSpeed = 30f;
    void Awake()
    {
        Debug.Log("** Awake()初始化");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("** Start()初始化");

    }

    // Update is called once per frame
    void Update()
    {
        //相对父物体旋转
        //float rotateSpeed = 60;
        Transform parent = this.transform.parent;
        parent.Rotate(0, rotateSpeed*Time.deltaTime, 0, Space.Self);
    }
    void OnEnable()
    {
        //Debug.Log("** OnEnable() 启用组件");

    }
    void OnDisable()
    {
        //Debug.Log("** OnDisable() 禁用组件");

    }
    //OnEnable每当组件启用时调用
    //OnDisable每当组件禁用时调用
}
