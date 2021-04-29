using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float destroyAfter = 1;
    [SerializeField] float speed = .05f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
    }

   void OnCollisionEnter(Collision collision)
    {
        if (transform.parent)
        {
            Destroy(gameObject.transform.parent, destroyAfter);
        }
        if (collision.gameObject.tag != "Player")
        {
            speed = 0;
            Destroy(gameObject);
            Debug.Log("collided");
        }
    }

}
