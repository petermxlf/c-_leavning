using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{

    [SerializeField] private int health;//血量变量
    [SerializeField] private UnityEvent healthChanged;//呼叫血条
    public int Value
    {
        get { return health; }
    }
    public void DecreaseHealth(int amount)
    {
        health -= amount;
        healthChanged.Invoke();//Invoke触发事件
    }
}
