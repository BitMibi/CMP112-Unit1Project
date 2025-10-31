using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    //Add Rigidbody reference
    private Rigidbody rb;

    //Declare movementX and Y for vectors later
    private float movementX;
    private float movementY;


    //Declared Public number to change speed of ball 
    public float speed = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         rb = GetComponent<Rigidbody>();
        
    }


    //On Move triggers when the input systems reads an input
    void OnMove(InputValue movementValue)
    {
        Vector2 movementvector = movementValue.Get<Vector2>();

        movementX = movementvector.x;
        movementY = movementvector.y;
        
    }


    // Fixed Update to add forces
    private void FixedUpdate()
    {
     
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
}
