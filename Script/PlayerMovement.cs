using System.Collections;
using System.Collections.Generic;
using System.Threading;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;//�������
    [SerializeField] private float speed;
    private Vector2 _inputDirection;
    public void Move(InputAction.CallbackContext context)
    {
        _inputDirection = context.ReadValue<Vector2>();//��ȡvector2������
        //Debug.Log(inputDirection);
    }
    private void FixedUpdate()//ÿ������ִ��һ��
    {
        var position = (Vector2)transform.position;
        var targetPosition = position + _inputDirection;

        if (position == targetPosition) return;
        rb.DOMove(targetPosition,speed ).SetSpeedBased();
    }
}
