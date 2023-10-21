using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{

    [SerializeField] private int health;//Ѫ������
    [SerializeField] private UnityEvent healthChanged;//����Ѫ��
    public int Value
    {
        get { return health; }
    }
    public void DecreaseHealth(int amount)
    {
        health -= amount;
        healthChanged.Invoke();//Invoke�����¼�
    }
}
