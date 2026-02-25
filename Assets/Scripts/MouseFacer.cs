using UnityEngine;
using UnityEngine.InputSystem;

public class MouseFacer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // angle needed to turn towards mouse
        float angle = GetAngle();
        
        angle = ConstrainAngle(angle);
        // rotate spirte to that angle
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    private float ConstrainAngle(float angle)
    {
        if (angle > 74f)
        {
            angle = 74f;
        }

        if (angle < -74f)
        {
            angle = -74f;
        }

        return angle;
    }

    private float GetAngle()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        float angle = CalculateAngle(mouseWorld);
        
        return angle;
    }

    private float CalculateAngle(Vector3 targetPosition)
    {
        Vector2 direction = (targetPosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle = angle + 90f;
        return angle;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        
        return mouseWorld;
    }
}
