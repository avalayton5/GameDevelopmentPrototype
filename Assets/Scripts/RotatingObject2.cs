using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingObject2 : MonoBehaviour
{
    public bool isActive = true;
    public float rotationSpeed = 10f;
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
        if (isActive)
        {
            float rotationThisFrame = rotationSpeed * Time.deltaTime;

            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
    }
}