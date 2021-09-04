using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshots : MonoBehaviour
{

	[SerializeField]
	public GameObject enemybullet;
	float fireRate;
	float nextFire;
	public Transform FirePoint;
	// Use this for initialization
	void Start()
	{
		fireRate = 3f;
		nextFire = Time.time;
	}

	// Update is called once per frame
	void Update()
	{
		CheckIfTimeToFire();

		
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			shoot();
		}

	}
	void shoot()
	{
		Instantiate(enemybullet, FirePoint.position, FirePoint.rotation);
	}

}

