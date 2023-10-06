using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylogic : MonoBehaviour
{
    [Tooltip("ǰ���ٶ�")]
    public float zspeed = 10;
    [Tooltip("ƽ���ٶ�")]
    float xspeed = 10;
    float lifetime = 15;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Snakemove", 1f, 1f);//ÿ��ı�һ��ƽ���ٶ�
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
        float[] options = { -10, -5, 5, 10 };//�����ٶ�ѡ��
        int sel = Random.Range(0, options.Length);//����ٶ�
        xspeed = options[sel];
    }
    private void EnumyDestroy()
    {
        Destroy(this.gameObject);
    }
}
