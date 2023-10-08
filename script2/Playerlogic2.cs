using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlogic2 : MonoBehaviour
{
    [Tooltip("移动速度")]
    public float speed = 10;
    [Tooltip("引用子弹预制体")]
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            this.transform.Translate(0, 0, speed * Time.deltaTime, Space.Self);
        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(-speed * Time.deltaTime, 0, 0, Space.Self);
        if (Input.GetKey(KeyCode.S))
            this.transform.Translate(0, 0, -speed * Time.deltaTime, Space.Self);
        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
        if (Input.GetMouseButtonDown(1))
        {
            this.transform.Rotate(0, 15f, 0, Space.Self);
        }
        if (Input.GetMouseButton(0))
        {
            GameObject node = Instantiate(bullet, this.transform);
            node.transform.position = this.transform.position;
        }

    }
}
