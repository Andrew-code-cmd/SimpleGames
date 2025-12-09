using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        transform.Rotate(Vector3.back, Time.deltaTime * rotationSpeed);
    }
}
