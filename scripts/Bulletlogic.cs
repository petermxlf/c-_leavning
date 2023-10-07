using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletlogic : MonoBehaviour
{
    [Tooltip("�ӵ������ٶ�")]
    public float speed=50;
    //public GameObject enumy;//Ӧ�õ���Ԥ����
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroys", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed*Time.deltaTime, Space.Self);
    }
    private void Destroys()
    {
        Object.Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider enumy)
    {
        Debug.Log("* ����other= " + enumy.name);
        if (!enumy.name.StartsWith("��")) return;
        Destroy(this.gameObject);//�����Լ�
        Destroy(enumy.gameObject);//���ٶԷ�
    }
}
