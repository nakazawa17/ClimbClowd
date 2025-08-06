using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("cat_0");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playersPos = player.transform.position;
        // y座標だけプレイヤの座標に連動して動く
        transform.position = new Vector3(transform.position.x, playersPos.y, transform.position.z);
    }
}
