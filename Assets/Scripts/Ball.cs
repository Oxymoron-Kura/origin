using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 5f;
    // 速さの最大値を指定する変数を追加
    public float minSpeed = 5f;
    // 速さの最小値を指定する変数を追加
    public float maxSpeed = 10f;
    Rigidbody myRigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.velocity = new Vector3(speed, speed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // 現在の速度を取得
        Vector3 velocity = myRigidbody.velocity;
        // 速さを計算
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        // 速度を変更
        myRigidbody.velocity = velocity.normalized * clampedSpeed;
    }
}
