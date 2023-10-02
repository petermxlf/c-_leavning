using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retatologic : MonoBehaviour
{
    public float Speed = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform parent = this.transform.parent;
        parent.Rotate(0,Speed * Time.deltaTime, 0, Space.Self);//相对父物体旋转
    }
}
