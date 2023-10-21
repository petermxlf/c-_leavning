using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Timers;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    private bool _canAttack=true;
    [SerializeField] private string targetTag;//Ŀ��ڵ�
    [SerializeField] private UnityEvent attack;
    private void OnTriggerEnter2D(Collider2D col)
    {
        DealDamage(col);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        DealDamage(other);
    }
    private void DealDamage(Collider2D other)
    {
        if (!_canAttack) return;
        if (other.CompareTag(targetTag))//�ж϶Է��ǲ���Ŀ��(ӵ�б�ǩ)
        {
            var damageable = other.GetComponent<Damageable>();//���Է������Ƕ�������ű�
            damageable.TakeDamage(1);//����һ���˺�
            TimersManager.SetTimer(this, 1, CanAttack);//��ȴ
            _canAttack = false;
            attack.Invoke();
        }
    }
    private void CanAttack()
    {
        _canAttack = true;
    }
}
