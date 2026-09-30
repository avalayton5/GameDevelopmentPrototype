using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingObject2 : MonoBehaviour
{
    public bool isActive = true;
    public float rotationSpeed = 10f;

    public bool isX;
    public bool isY;
    public bool isZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("RotatingObstacle is running.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            isActive = !isActive;
        }
        if (isActive  && isX)
        {
            float rotationThisFrame = rotationSpeed * Time.deltaTime;

            transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
        }

        if (isActive && isY)
        {
            float rotationThisFrame = rotationSpeed * Time.deltaTime;

            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }

        if (isActive && isZ)
        {
            float rotationThisFrame = rotationSpeed * Time.deltaTime;

            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
    }
}