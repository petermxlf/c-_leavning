using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubelogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (IsInvoking("Expand"))
            {
                CancelInvoke("Expand");//ֹͣ����
            }
            else
            {
                InvokeRepeating("Expand", 1, 1);
            }
            //����С�Ľ��������ζ�ʱ���ã���ô���ε��ö�����Ч�����Ƕ�����
            //InvokeRepeating("Expand", 1, 1);

            //InvokeRepeating("Expand", 1, 1);
        }
    }
    private void Expand()
    {
        Debug.Log("* �䳤  . ." + Time.time);

        Vector3 scale = this.transform.localScale;
        scale.y += 1;
        this.transform.localScale = scale;
    }
}
