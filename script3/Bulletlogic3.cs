using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�ӵ�����
public class Bulletlogic3 : MonoBehaviour
{
    public float speed;//�����ٶ�

    public float maxdistance;//�����о���

    // Start is called before the first frame update
    void Start()
    {
        float lifetime = 1;
        if (speed > 0)
        {
            lifetime = maxdistance / speed;
        }
        //Invoke("selfdestroy", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed, Space.Self);
    }
    private void selfdestroy()
    {
        Debug.Log("* �Ի� . .");
        Object.Destroy(this.gameObject);//���ٵ�ǰԤ����ʵ��
    }
}
