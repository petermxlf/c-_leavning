using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movelogic : MonoBehaviour
{
    public float Speed;//ת��
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Rotate(0, Speed * Time.deltaTime,0 , Space.Self);//����������ת
        this.transform.Rotate(0, Speed * Time.deltaTime,0 , Space.World);//����������ת
    }
    public void DoRotate()
    {
        Debug.Log("** ִ�У�DoRotate");

        Speed = 180;
    }
}
