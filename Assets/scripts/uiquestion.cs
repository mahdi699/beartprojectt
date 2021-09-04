using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiquestion : MonoBehaviour
{
	 
    
    
	public GameObject gate;
	 public GameObject ui;
     public GameObject f1;
     public GameObject f2;

    private void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter2D(Collider2D other )
	{
		 
		if (other.transform.tag == "Player")
		{
			 gate.SetActive(true);
              ui.SetActive(true);
              f1.SetActive(false);
              f2.SetActive(false);
			Time.timeScale = 0;
			Destroy(gameObject);
			
      Debug.Log("destroyed") ;
		}
		
		
     
 }
    
}
