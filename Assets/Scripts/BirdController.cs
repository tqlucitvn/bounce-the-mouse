using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float speed = 30.0f;
    Rigidbody2D birdRb;
    // void Awake()
    // {
    //     birdRb = GetComponent<Rigidbody2D>();
    // }

    void Start()
    {
        birdRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        birdRb.transform.Translate(Vector2.left * Time.deltaTime * speed);
        // birdRb.MovePosition(Vector2.left * Time.deltaTime * speed);
    }
}
