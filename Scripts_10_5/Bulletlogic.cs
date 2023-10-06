using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletlogic : MonoBehaviour
{
    [Tooltip("�ӵ������ٶ�")]
    public float speed = 1;
    [Tooltip("�ӵ�����ʱ��")]
    public float lifetime = 3;
    [Tooltip("������Ч")]
    public GameObject explosionEffe;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestroy", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed*Time.deltaTime, Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("* �ӵ���ײ other= " + other.name);

        if (!other.name.StartsWith("����")) return;//���Է��������Ƿ��ǹ��޿�ͷ,������ǲ�ִ�к�������

        Destroy(this.gameObject);//�����Լ�
        Destroy(other.gameObject);//���ٶԷ�

        //����һ��������Ч
        //GameObject effectnode = Instantiate(explosionEffe, null);
        //effectnode.transform.position = this.transform.position;
        //��������Ч������֮����Լ�����
    }
    private void SelfDestroy()
    {
        Object.Destroy(this.gameObject);
    }
}
