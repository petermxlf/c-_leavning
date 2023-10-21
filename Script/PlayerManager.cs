using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;//ÕÊº“Œª÷√

    public Vector2 Position
    {
        get { return playerTransform.position; }
    }
}
