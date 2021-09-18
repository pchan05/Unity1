using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int keyx = 0;
    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyx = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) keyx = -1;
        if (Input.GetKey(KeyCode.RightArrow)) keyx = 1;

        transform.Translate(speed * keyx*Time.deltaTime, 0,0);

        Vector3 pos = this.transform.position;
        if (pos.x < -8) pos.x = -8;
        if (pos.x > 8) pos.x = 8;
        transform.position = pos;
    }
}
