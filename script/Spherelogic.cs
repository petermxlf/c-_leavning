using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spherelogic : MonoBehaviour
{
    public GameObject mubiao;
    Transform Child;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Child = this.transform.GetChild(0);
        Vector3 p1 = mubiao.transform.position;
        Vector3 p2 = this.transform.position;
        Vector3 p = p1 - p2;
        float speed = p.magnitude;
        Child.transform.Translate(0, 0, 5 * Time.deltaTime, Space.Self);
        if (speed < 1.0f)
        {
            mubiao.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Child.transform.Rotate(0, 180, 0, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Child.transform.Rotate(0, -90, 0, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Child.transform.Rotate(0, 90, 0, Space.Self);
        }
    }
    void Move()
    {
    }
}
