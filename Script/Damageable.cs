using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Damageable : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Color _defaultColor;//����ԭ����ɫ
    public void TakeDamage(int damage)
    {
        health.DecreaseHealth(damage);
        spriteRenderer.DOColor(Color.red, 0.2f).
            SetLoops(2,LoopType.Yoyo).ChangeStartValue(_defaultColor);//��ɫת��

    }
    private void Awake()
    {
        _defaultColor = spriteRenderer.color;
    }
}
