using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] private Transform obj;
    [SerializeField] float teleportOffset = 1f;

    private void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(obj.position);

        if (screenPos.x < 0f)
        {
            Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width + teleportOffset, screenPos.y, screenPos.z));
            obj.position = newPos;
        }
        else if (screenPos.x > Screen.width)
        {
            Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(-teleportOffset, screenPos.y, screenPos.z));
            obj.position = newPos;
        }
    }
}
