using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfire : MonoBehaviour
{
    public GameObject fire;//引用子弹预制体
    public float fire_speed=0.5f;//开火间隔
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("testfire", fire_speed, fire_speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void testfire()
    {
        GameObject node = Instantiate(fire, this.transform);
        node.transform.position = this.transform.position;
    }
}
