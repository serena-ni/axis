using UnityEngine;

public class LandscapeController : MonoBehaviour
{
    public float rotationSpeed = 40f;
    public float smoothness = 5f;

    float targetRotation = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            targetRotation += rotationSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            targetRotation -= rotationSpeed * Time.deltaTime;

        float currentZ = transform.eulerAngles.z;
        float smoothZ = Mathf.LerpAngle(currentZ, targetRotation, smoothness * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0, 0, smoothZ);
    }
}
