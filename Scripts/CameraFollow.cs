using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float yOffset = 2.0f;

    private void LateUpdate()
    {
        float targetY = target.position.y + yOffset;
        float currentY = transform.position.y;
        if (targetY > currentY)
        {
            float newY = Mathf.Lerp(currentY, targetY, Time.deltaTime);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }
}
