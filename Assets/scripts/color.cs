using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{ 
	 
     private void OnTriggerEnter2D(Collider2D other )
	{
		if (other.transform.tag == "Player")
		{
			Destroy(gameObject);
		
			 
			
		}
			if (other.transform.tag == "Bullet")
		{
			 
			Destroy(gameObject);
			
      Debug.Log("destroyed") ;
		}
		
	}	
}
