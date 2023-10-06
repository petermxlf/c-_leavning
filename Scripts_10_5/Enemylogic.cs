using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylogic : MonoBehaviour
{
    [Tooltip("前进速度")]
    public float zspeed = 10;
    [Tooltip("平移速度")]
    float xspeed = 10;
    float lifetime = 15;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Snakemove", 1f, 1f);//每秒改变一次平移速度
        Invoke("EnumyDestroy", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        float dz = zspeed * Time.deltaTime;
        float dx = xspeed * Time.deltaTime;
        this.transform.Translate(dx, 0, dz, Space.Self);
    }
    private void Snakemove()
    {
        float[] options = { -10, -5, 5, 10 };//四种速度选项
        int sel = Random.Range(0, options.Length);//随机速度
        xspeed = options[sel];
    }
    private void EnumyDestroy()
    {
        Destroy(this.gameObject);
    }
}
