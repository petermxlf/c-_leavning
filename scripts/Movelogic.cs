using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movelogic : MonoBehaviour
{
    public float Speed;//转速
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Rotate(0, Speed * Time.deltaTime,0 , Space.Self);//依照自身旋转
        this.transform.Rotate(0, Speed * Time.deltaTime,0 , Space.World);//依照自身旋转
    }
    public void DoRotate()
    {
        Debug.Log("** 执行：DoRotate");

        Speed = 180;
    }
}
