using UnityEngine;

public class LandscapeController : MonoBehaviour
{
    public float rotationSpeed = 120f;
    public float maxAngle = 30f;

    float currentAngle = 0f;

    void Update()
    {
        float input = 0f;

        if (Input.GetKey(KeyCode.A))
            input = 1f;

        if (Input.GetKey(KeyCode.D))
            input = -1f;

        currentAngle += input * rotationSpeed * Time.deltaTime;

        currentAngle = Mathf.Clamp(currentAngle, -maxAngle, maxAngle);

        transform.rotation = Quaternion.Euler(0, 0, currentAngle);
    }
}
