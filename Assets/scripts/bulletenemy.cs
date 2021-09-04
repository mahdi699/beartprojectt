using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	float moveSpeed = 3f;

	Rigidbody2D rb;

	 player2 target;
	Vector2 moveDirection;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		target = GameObject.FindObjectOfType<player2>();
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.tag == "player2")
		{
			Debug.Log("Hit!");
			Destroy(gameObject);
		}
		
	}

}
