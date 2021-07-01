using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;

    public float cameraSpeed = 0.5f;

    public float maxSpeed = 0.1f;

    Vector3 velocity = Vector3.zero;

    public Vector3 offset;
    void LateUpdate()
    {
        Vector3 aimPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, aimPos, cameraSpeed * Time.deltaTime);

        //Vector3 smoothPos = Vector3.SmoothDamp(transform.position, aimPos, ref velocity, cameraSpeed * Time.deltaTime, maxSpeed);

        transform.position = smoothPos;

        //transform.LookAt(target, target.up);

    }
}
