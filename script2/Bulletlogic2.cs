using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletlogic2 : MonoBehaviour
{
    [Tooltip("�ӵ������ٶ�")]
    public float speed = 30f;
    [Tooltip("�ӵ���������")]
    public float firetime = 3f;
    int count=0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("testDestroy", firetime);//��������
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed * Time.deltaTime,Space.Self);
    }
    private void testDestroy()
    {
        Destroy(this.gameObject);//�����ӵ�
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.name.StartsWith("����")) return;
        Debug.Log("** ����*" + count);
        count++;
        Destroy(this.gameObject);
        Destroy(other.gameObject);
    }
}
