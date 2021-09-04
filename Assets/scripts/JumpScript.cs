using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI ;
public class JumpScript : MonoBehaviour
{
     
    
     public GameObject f1;
     public GameObject f2;
     public GameObject f3;
      public GameObject f5;
       
      

    public float velocity = 15;
    private Rigidbody2D rb;
 float speedanonymousultiplier = 4;
   
   public Text MyText;
       public static int score;

    public Transform FirePoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
     
           MyText.text = "";
           score = 0 ;
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.right * Time.deltaTime * speedanonymousultiplier);
          
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = Vector2.up * velocity;
        }   
        MyText.text = "" + score;
        
         if (Input.GetButtonDown("Fire2") && (score>=1))
        {   
            shoot();
             score = score -1 ; 
        }
     }
  

    private void OnTriggerEnter2D(Collider2D other )
	{
		if (other.transform.tag == "Obstacle")
		{
			
              f1.SetActive(false);
              f2.SetActive(false);
              f3.SetActive(false);
              f5.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);


            Debug.Log("helahopa") ;
		} 
        if (other.transform.tag == "Music")
		{
			
            Debug.Log("wiiw") ;
			score = score + 1 ;
		}
         if (other.transform.tag == "enemy")
        {
            
              f1.SetActive(false);
              f2.SetActive(false);
              f3.SetActive(false);
             
              f5.SetActive(true);

            Destroy(gameObject);
            Debug.Log("deaddd ");

        }
         if (other.transform.tag == "killenemy")
		{
			
              f1.SetActive(false);
              f2.SetActive(false);
              f3.SetActive(false);
              f5.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);


            Debug.Log("helahopa") ;
		}
        if (other.transform.tag == "thenemy")
        {

            f1.SetActive(false);
            f2.SetActive(false);
            f3.SetActive(false);
            f5.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);


            Debug.Log("helahopa");
        }
        if (other.transform.tag == "fenemy")
        {

            f1.SetActive(false);
            f2.SetActive(false);
            f3.SetActive(false);
            f5.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);


            Debug.Log("helahopa");
        }

    } 
     void shoot()
    {
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }

     

}