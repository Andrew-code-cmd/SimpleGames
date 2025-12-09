using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed, turnSpeed;
    private float horizontalInput, verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(speed * Time.deltaTime * Vector3.forward); // движение прямо по дефолту


        transform.Rotate(Vector3.back, Time.deltaTime * turnSpeed * horizontalInput); // повороты в стороны
        transform.Rotate(Vector3.left, Time.deltaTime * turnSpeed * -verticalInput); // наклоны вверх и вниз
    }
}
