using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firlogic2 : MonoBehaviour
{
    //�����˶�Ԥ���������
    public GameObject bulletprefab;//�ڵ����ͱ���
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Testfire();
        }
    }
    private void Testfire()
    {
        Debug.Log("* �����ӵ���ʵ�� . .");
        //Ԥ����ʵ�������������µĽڵ�
        GameObject node=Object.Instantiate(bulletprefab, null);//���´�����ʵ������null��(��Ŀ¼��)
        node.transform.position = Vector3.zero;//�ѽڵ������������
        node.transform.localEulerAngles = Vector3.zero;
    }
}
