using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeowController : MonoBehaviour
{
    public float startDelay = 2.0f;
    public float fireRate = 2.0f;
    public GameObject projectilePrefab;
    public float launchForce = 0.0f;
    // Rigidbody2D meowRb;
    // Start is called before the first frame update
    void Start()
    {
        // meowRb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Launch", startDelay, fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Launch(){
        GameObject player = GameObject.Find("Mouse");
        if (!player){
            Debug.Log("Can not find player GameObject");
        }
        Vector2 direction = player.transform.position - transform.position;
        GameObject projectileObject = Instantiate(projectilePrefab, transform.position + Vector3.up, Quaternion.identity);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(direction, launchForce);
    }
}
