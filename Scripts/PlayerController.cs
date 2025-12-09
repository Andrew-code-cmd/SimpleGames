using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 65.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // движется прямо по дефолту
        
        if(forwardInput > 0)
        {
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); // поворот в стороны
        }
        else if(forwardInput < 0)
        {
            transform.Rotate(-Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }

            // поворот в стороны (old)
            // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
