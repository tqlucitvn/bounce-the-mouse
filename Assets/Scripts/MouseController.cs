using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    // Rigidbot
    private Rigidbody2D _playerRb {get; set;}
    // Input
    float verticle = 0.0f; 
    float horizontal = 0.0f; 
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
    }

    public void Jump(){
        _playerRb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
