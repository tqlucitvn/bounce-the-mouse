using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public float repeatWidth = 0.0f;
    public Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Debug.Log("Start Pos :" + startPos);
        repeatWidth = GetComponent<BoxCollider2D>().size.x/2;
        Debug.Log("Start repeatWidth :" + repeatWidth);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth){
            transform.position = startPos;
        }
    }
}
