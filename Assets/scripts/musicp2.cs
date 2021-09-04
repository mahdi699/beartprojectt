using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicp2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "player2")
        {
            Destroy(gameObject);
        }
    }
}
