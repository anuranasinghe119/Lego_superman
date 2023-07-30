using UnityEngine;

public class ArmRotation : MonoBehaviour
{
    public Transform armTransform; // Reference to the arm's transform component
    public float rotationAmount = 90f; // The amount of rotation in degrees

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Change 'KeyCode.Space' to the desired button
        {
            RotateArm();
        }
    }

    void RotateArm()
    {
        // Rotate the arm around its local y-axis (or the desired axis)
        armTransform.Rotate(Vector3.up, rotationAmount);
    }
}
