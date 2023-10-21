using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Timers;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    private bool _canAttack=true;
    [SerializeField] private string targetTag;//目标节点
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
        if (other.CompareTag(targetTag))//判断对方是不是目标(拥有标签)
        {
            var damageable = other.GetComponent<Damageable>();//检查对方身上是都有这个脚本
            damageable.TakeDamage(1);//给予一点伤害
            TimersManager.SetTimer(this, 1, CanAttack);//冷却
            _canAttack = false;
            attack.Invoke();
        }
    }
    private void CanAttack()
    {
        _canAttack = true;
    }
}
