using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycreator : MonoBehaviour
{
    [Tooltip("敌人预制体资源")]
    public GameObject enemyprefab;

    [Tooltip("敌人刷新时间")]
    public float interval = 1;
    // Start is called before the first frame update
    void Start()
    {
        //Createenemy();

        InvokeRepeating("Createenemy", 0.1f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Createenemy()
    {
        GameObject node = Instantiate(enemyprefab, this.transform);
        node.transform.position = this.transform.position;
        //node.transform.localEulerAngles = new Vector3(0, 180, 0);

        float dx = Random.Range(-100, 100);//设置随机出生点
        node.transform.Translate(dx, 0, 0, Space.Self);
    }
}
