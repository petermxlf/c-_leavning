using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylogic : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("testmove", 10f, 5f);//每5秒刷新一个敌人
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void testmove()
    {
        GameObject node = Instantiate(enemy, this.transform);
        node.transform.position = this.transform.position;

        float dx = Random.Range(-50, 50);
        node.transform.Translate(dx, 0, 0, Space.Self);
    }
}
