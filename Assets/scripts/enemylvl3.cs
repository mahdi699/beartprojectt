﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemylvl3 : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
