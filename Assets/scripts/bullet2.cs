using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour
{
    
    public float speed = 20f;
    public Rigidbody2D rrb;
    // Start is called before the first frame update

    private void Awake()
    {  
    rrb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate ()
    {
            
            rrb.velocity = Vector2.right * speed;
        
    }

    private void OnTriggerEnter2D(Collider2D col )
    {
        if (col.transform.tag == "Obstacle")
        {
            Debug.Log("hit enemy ");
            Destroy(gameObject);

        }
         if (col.transform.tag == "enemy")
        {
            Debug.Log("hit enemy ");
            Destroy(gameObject);

        }

        if (col.transform.tag == "killenemy")
        {
            Debug.Log("hit enemy ");
            Destroy(gameObject);

        }
        if (col.transform.tag == "thenemy")
        {
            Debug.Log("hit enemy ");
            Destroy(gameObject);

        }
        if (col.transform.tag == "fenemy")
        {
            Debug.Log("hit enemy ");
            Destroy(gameObject);

        }

        if (col.transform.tag == "finalboss")
        {
            Debug.Log("hit enemy ");
            Destroy(gameObject);

        }


    }
    // Update is called once per frame                  

}
