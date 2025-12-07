using UnityEngine;

public class wheelRotate : MonoBehaviour
{
    public float rotationSpeed;
    public bool isLeftAndRightRotating;

    private float verticalInput;
    private float horizontalInput;

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (isLeftAndRightRotating)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);
        }

        transform.Rotate(-Vector3.left, Time.deltaTime * rotationSpeed * verticalInput);
    }
}
