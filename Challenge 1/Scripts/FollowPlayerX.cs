using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0.5f, 4.3f, -11.57f);

    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
