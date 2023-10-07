using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Firelogic : MonoBehaviour
{
    [Tooltip("引用子弹预制体")]
    public GameObject fire;
    [Tooltip("发射间隔")]
    public float speed=0.5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            testfire();
        }
    }
    private void testfire()
    {
        GameObject node = Object.Instantiate(fire, this.transform);
        node.transform.position = this.transform.position;
    }
}
