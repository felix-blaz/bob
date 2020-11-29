using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookdirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookdirection * speed);
        
        if(transform.position.y < -1)
        {
            Destroy(gameObject);
        }
    }
}
