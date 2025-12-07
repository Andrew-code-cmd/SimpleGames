using UnityEngine;

public class otherVehicles : MonoBehaviour
{
    public float movingSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movingSpeed);
    }
}
