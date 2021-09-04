using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class music : MonoBehaviour
{
	 private void OnTriggerEnter2D(Collider2D other )
	{
		if (other.transform.tag == "Player")
		{
			Destroy(gameObject);
		}
		
	}	
}
