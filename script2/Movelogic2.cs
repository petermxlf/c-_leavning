using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ͨ���ƶ��ű�
public class Movelogic2 : MonoBehaviour
{
    //public float speed = 2f;
    public Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = speed * Time.deltaTime;
        this.transform.Translate(delta,Space.Self);//��ά�ƶ�
    }
}
