using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    float speed = 0;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            speed = Random.Range(-2, 2);
            speed *= 0.03f;
            Debug.Log("スピード：" + speed);

        }
        if (transform.position.x < -2.8)
        {
            speed = 0.03f;
        }
        if (transform.position.x > 2.8)
        {
            speed = 0.03f;
        }
        transform.Translate(speed, 0, 0);
    }
}
