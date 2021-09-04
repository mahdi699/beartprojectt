using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theboss: MonoBehaviour
{
	public GameObject halfhp;
	public GameObject fullhp;
	public GameObject qhpp; 
	public GameObject onehph;
	public  GameObject victory ;
	private int fullhpp;

	private int health = 30;
	void start()
	{
		health = fullhpp;
		Time.timeScale = 1;

	}


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "Player")
		{
			Destroy(gameObject);
		}
		if (other.transform.tag == "Bullet")
		{

			halfhp.SetActive(true);
			fullhp.SetActive(false);
			onehph.SetActive(false);
			qhpp.SetActive(false);
			Debug.Log(" half hp ");
			health -= 10;

			if (health <= 20)
			{
				halfhp.SetActive(false);
				fullhp.SetActive(false);
				onehph.SetActive(false);
				qhpp.SetActive(true);
				Debug.Log(" quarter hp ");
			}
			if (health <= 10)
			{
				halfhp.SetActive(false);
				fullhp.SetActive(false);
				onehph.SetActive(true);
				qhpp.SetActive(false);
				Debug.Log(" one hp ");
			}

			if (health <= 0)
			{
				onehph.SetActive(false);
				Destroy(gameObject);
				victory.SetActive(true);
				Time.timeScale = 0;
			}

		}



	}



}
