using UnityEngine;
using UnityEngine.SceneManagement; 

public class FlagColiider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        //Add a debug message here for score/time/a secret third thing 

        string output = "You reached the goal! Final Score: "; //+ score     maybe add later 

        Debug.Log(output); 


        SceneManager.LoadScene("EndOfGame"); //Should load the last scene when the flag is touched.


    }
}
