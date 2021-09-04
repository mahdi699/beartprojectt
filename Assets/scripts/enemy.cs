using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
     public GameObject halfhp;
     public GameObject fullhp; 
	
	 private int fullhpp ;

	 private int health =30 ;
	 void start ()
	 {
		 health = fullhpp ;
		 
	 }
	
	
     private void OnTriggerEnter2D(Collider2D other )
	{
		if (other.transform.tag == "Player")
		{
			Destroy(gameObject);
		}
			if (other.transform.tag == "Bullet")
		{
			     
                  halfhp.SetActive(true);
			     fullhp.SetActive(false);
			     
                 Debug.Log(" half hp ") ;
				  health -=  10 ;

			
			if (health<=0)
		 {
			 Destroy(gameObject) ;
		 }
				 
		} 
		 
		
	
	}

	
	 	
}
