using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    Rigidbody2D rigidBody;
    // void Awake()
    // {
    //     birdRb = GetComponent<Rigidbody2D>();
    // }

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.transform.Translate(Vector2.left * Time.deltaTime * speed);
        // birdRb.MovePosition(Vector2.left * Time.deltaTime * speed);
    }
}
