﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D other )
	{
		if (other.transform.tag == "Player")
		{
			Destroy(gameObject);
      Debug.Log("destroyed") ;
		}
     
 }  
}
