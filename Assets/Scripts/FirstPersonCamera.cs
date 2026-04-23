using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    private float xAxis;
    private float yAxis;

    float xAxisTurnRate = 540f;
    float yAxisTurnRate = 540f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //float xAxisInput = Input.GetAxis("Mouse Y");
        //float yAxisInput = Input.GetAxis("Mouse X");

        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
    }

    public void AddXAxisInput(float input)
    {
        xAxis -= input * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -90f, 90f);
    }

    public void AddYAxisInput(float input)
    {
        yAxis += input * yAxisTurnRate;
    }
}
