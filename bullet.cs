using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private int speed =5;
    public Rigidbody body;
    public Vector3 newVelocity;
    
    private void Start()
    {
        Destroy(gameObject, 3);
        
            
    }
     void OnTriggerEnter(Collider collision)
    {
        bool IsEnemy = collision.gameObject.tag == "enemy";
            if(IsEnemy)
        {
            Destroy(collision.gameObject);
        }
    
            
    }

    // Update is called once per frame
    void Update()
    {
        newVelocity = transform.forward * speed;
        body.velocity = newVelocity;


    }
}
