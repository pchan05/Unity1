using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//쩝쩝

public class ArrowController : MonoBehaviour
{
    public float speed = 5f;
    GameObject player;
    private Vector2 dis;
    GameObject Gamedirector;
    
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.Gamedirector = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, -speed * Time.deltaTime, 0);

        if (transform.position.y < -5f) Destroy(gameObject);

        dis = transform.position - player.transform.position;

        if (dis.magnitude<1.5f)
        {
            Gamedirector.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);
        }

    }
}
