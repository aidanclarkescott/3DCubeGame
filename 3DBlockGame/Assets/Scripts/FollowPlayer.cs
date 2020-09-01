using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform playerPos;
    public Vector3 cameraOffset;

    // Update is called once per frame
    void Update() {
        transform.position = playerPos.position + cameraOffset;
    }
}