using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    Rigidbody2D rb2d;

    bool isDead;

    public float speed = 5;
    
    //Use SerializeField to edit a variable from the inspector even if it's private
    [SerializeField]
    private float flapForce = 20;
    // use this for initialization 
    void Start()
    {
        //Freeze time to wait for the player to press Play
        Time.timeScale = 0;
        //Get a reference to the Rigidbody2D of the Bird
        rb2d = GetComponent<Rigidbody2D>();
        //Go right
        rb2d.velocity = Vector2.right * speed * Time.deltaTime; 
    }
    
    public void UnFreeze()
    {
        Time.timeScale = 1;
    }
    //DO NOT COPY/PASTE THIS CODE, Edit the existing one.

    //Add a public GameObject variable and drag your Button in the Inspector
    public GameObject ReplayButton;

    void OnCollisionEnter2D(Collision2D col)
    {
       isDead = true;
       rb2d.velocity = Vector2.zero;
       //Set the ReplayButton to active to show it in the scene 
       ReplayButton.SetActive(true);
       //Change the isDead parameter of the animator to start the dead animation
       GetComponent<Animator>().SetBool("isDead", true);
       //GetComponent<animator>() is a reference to the animator of the bird.
    }
     // Update is called once per frame
    void Update()
    {
       //Wait for flap Input
       if (Input.GetMouseButtonDown(0) && !isDead) {
           //Reset Velocity 
           rb2d.velocity = Vector2.right * speed * Time.deltaTime;

           //Add UP force to the bird
           rb2d.AddForce(Vector2.up * flapForce);
       }
    }
        int score = 0;
        public Text scoreText;
        void OnTriggerEnter2D(Collider2D col)
    {
       if(col.gameObject.tag == "Score")
       {
           //Increment score
           score++;
           //Show the score in the console
           Debug.Log(score);
           //Update Text
           scoreText.text = score.ToString();
       }
    }

    public void Replay()
    {
        //This line changes the scene to the scene 0 in your build seettings
        SceneManager.LoadScene(0);
    }

   
 
}
