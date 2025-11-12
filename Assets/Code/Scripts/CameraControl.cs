using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControl : MonoBehaviour
{
    public GameObject player;       //Object camera is tied to
    private Vector3 offset;         //Used to keep distance from player when moving
    public Vector3 initialOffset;       //Initial Camera Offset -- Can be changed in engine
    public Quaternion initialRotation; //Initial Camera Rotation -- Should be able to be changed in engine??
    private Quaternion rotationOffset;              //Set how much the camera is rotated on movement
    public float rotationVal;         //Multiplier to the rotation


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //Sets the initial Rotation and position of the camera.
        transform.rotation = initialRotation;
        transform.position = player.transform.position + initialOffset;

        //KEEPS the inital position of the camera.
        offset = transform.position - player.transform.position;        //Distance away from player
    }


    void OnMove(InputValue movementValue)
    {
        Vector2 rotationVector = movementValue.Get<Vector2>();      //attempting something stupid -- WORKED????

        rotationOffset.x = rotationVector.x;
        rotationOffset.y = rotationVector.y;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;        // Changes the position to follow the player as they move

        
    }

    void FixedUpdate()
    {
        if (Input.anyKeyDown)
        {
            transform.rotation = Quaternion.Euler(initialRotation.x + rotationOffset.y * rotationVal, initialRotation.y + rotationOffset.x * rotationVal, initialRotation.z);
        }
        else
        { 
            transform.rotation = Quaternion.Euler(initialRotation.x - rotationOffset.y * rotationVal, initialRotation.y - rotationOffset.x * rotationVal, 0);
        }
    }
}
