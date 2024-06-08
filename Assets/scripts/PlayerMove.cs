using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float _movePower = 10f;
    //進む力
    private Vector3 dir = default;
    //
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw ("Horizontal");
        //左右の入力
        float z = Input.GetAxisRaw ("Vertical");
        //上下の入力
        dir = new Vector3(x, 0, -z);

        _rb.velocity = dir * _movePower;
    }
}
