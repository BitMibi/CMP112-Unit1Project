using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    //Add Rigidbody reference
    private Rigidbody rb;

    //Initialises the score variable
    private int score;

    //Declare movementX and Y for vectors later
    private float movementX;
    private float movementY;


    //Declared Public number to change speed of ball 
    public float speed = 0;

    public TextMeshProUGUI scoreText;


    //Audio
    private AudioSource source;
    public AudioClip pickupSound;

    public float lowPitchRange = 0.0f;
    public float highPitchRange = 3.0f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         rb = GetComponent<Rigidbody>();

        score = 0;

        SetScoreText();


        //Activate Audio Source
        source = GetComponent<AudioSource>();
    }


    //On Move triggers when the input systems reads an input
    void OnMove(InputValue movementValue)
    {
        Vector2 movementvector = movementValue.Get<Vector2>();

        movementX = movementvector.x;
        movementY = movementvector.y;
        
    }

    // Changes the text display of the score
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }


    // Fixed Update to add forces
    private void FixedUpdate()
    {
     
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    //IGNORE THIS   
    private void playAudio()
    {
        source.PlayOneShot(pickupSound, 1.0f);
        source.pitch = Random.Range(lowPitchRange, highPitchRange);
    }

    // Removes PickUps when colliding with them
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            

            other.gameObject.SetActive(false);
            playAudio();

            score += 1;

            SetScoreText();

            
        }
        
    }
    
}


