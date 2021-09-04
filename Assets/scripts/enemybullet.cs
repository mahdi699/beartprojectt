using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{

	float moveSpeed = 5f;

	Rigidbody2D rb;

	player2 target;
	Vector2 moveDirection;

	// Use this for initialization
	void Start()
	{
		
		rb = GetComponent<Rigidbody2D>();
		target = GameObject.FindObjectOfType<player2>();
		moveDirection = (target.transform.position ).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);

	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "player2")
		{
			Destroy(gameObject);
		
		}
	}

}