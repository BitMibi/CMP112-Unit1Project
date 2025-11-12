using UnityEngine;

public class Respawn : MonoBehaviour {

    public float threshold;

    void FixedUpdate() {
        if (transform.position.y < threshold) {
            transform.position = new Vector3(0.31686f, 0.5f, 0.31686f);
        }
    }
}
