using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        // Rigitbody2Dコンポーネントの参照を取得
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // transform.up:上方向の矢印(ベクトル)　＊ ジャンプ力
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }

        // velocity:移動速度を調べる
        float speedx = Math.Abs(this.rigid2D.velocity.x);

        // スピード制限(連打すると加速し続けるため)
        if (speedx < this.maxWalkSpeed)
        {
            // 右方向ベクトル(左キーを押した場合は負の値となるため左向きに力が働く)
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        animator.speed = speedx / 2.0f;
    }
}
