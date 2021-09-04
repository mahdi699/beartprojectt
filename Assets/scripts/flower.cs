using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower : MonoBehaviour
{
	public GameObject gate;
	 
private void OnTriggerEnter2D(Collider2D other )
	{
		 
		if (other.transform.tag == "Player")
		{
			 gate.SetActive(true);
			Destroy(gameObject);
			
      Debug.Log("destroyed") ;
		}
		
		
     
 }
  
}
