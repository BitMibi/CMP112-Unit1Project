using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;       //Object camera is tied to
    private Vector3 offset;
    public Vector3 initialOffset;       //Initial Camera Offset -- Can be changed in engine
    public Quaternion initialRotation; //Initial Camera Rotation -- Should be able to be changed in engine??
    public Quaternion rotationOffset;              //Set how much the camera is rotated on moveement


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //Sets the initial Rotation and position of the camera.
        transform.rotation = initialRotation;
        transform.position = player.transform.position + initialOffset;

        //KEEPS the inital position of the camera.
        offset = transform.position - player.transform.position;        //Distance away from player
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;        // Changes the position to follow the player as tey move

        




    }

}
