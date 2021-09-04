using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class player2: MonoBehaviour
{


    public GameObject f1;
    public GameObject f2;
    public GameObject f3;
    public GameObject f5;
    public GameObject halfhp;
    public GameObject fullhp;
    public GameObject onehp;
      private int health = 30;
    public float velocity = 15;
    private Rigidbody2D rb;
   

    public Text MyText;
    public static int score;

    public Transform FirePoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "";
        score = 0;
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = Vector2.up * velocity;
        }
        MyText.text = "" + score;

        if (Input.GetButtonDown("Fire2") && (score >= 1))
        {
            shoot();
            score = score - 1;
        }
    }


    
    void shoot()
    {
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Obstacle")
        {

            f1.SetActive(false);
            f2.SetActive(false);
            f3.SetActive(false);
            f5.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);


            Debug.Log("helahopa");
        }

        if (other.transform.tag == "Music")
        {

            Debug.Log("wiiw");
            score = score + 1;
        }

        if (other.transform.tag == "enemybulelt")
        {
            fullhp.SetActive(false);
            Debug.Log(" half hp ");
            health -= 10;
            if (health <= 10)
            {
                halfhp.SetActive(false);

                Debug.Log(" one hp ");
            }

            if (health <= 0)
            {

                onehp.SetActive(false);
                f5.SetActive(true);
                Destroy(gameObject);
                Time.timeScale = 0;
            }

        }
    }



}