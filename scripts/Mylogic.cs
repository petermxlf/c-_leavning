using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mylogic : MonoBehaviour
{
    [Tooltip("玩家移动速度")]
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-speed, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(speed, 0, 0, Space.Self);
        }
        if (Input.GetMouseButtonDown(1))
        {
            this.transform.Rotate(0,45f,0,Space.Self);
        }
    }
}
