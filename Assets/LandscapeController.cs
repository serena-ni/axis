using UnityEngine;

public class LandscapeController : MonoBehaviour
{
    public float rotationSpeed = 120f;

    void Update()
    {
        float input = 0f;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            input = 1f;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            input = -1f;

        transform.Rotate(Vector3.forward, input * rotationSpeed * Time.deltaTime);
    }
}
