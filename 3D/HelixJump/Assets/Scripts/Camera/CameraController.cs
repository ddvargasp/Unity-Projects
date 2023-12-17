using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public BallController ballController;

    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.y - ballController.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicionAcutal = transform.position;
        posicionAcutal.y = ballController.transform.position.y + offset;
        transform.position = posicionAcutal;
    }
}
