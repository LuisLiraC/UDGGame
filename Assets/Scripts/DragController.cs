using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour
{
    [SerializeField] private static GameObject draggableSprite;
    Vector3 startPosition;
    float zDistanceToCamera;
    Vector3 touchOffset;

    public void OnMouseDown()
    {
        draggableSprite = gameObject;
        startPosition = transform.position;
        zDistanceToCamera = Mathf.Abs(startPosition.z - Camera.main.transform.position.z);
        touchOffset = startPosition - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceToCamera)
        );
    }

    public void OnMouseDrag()
    {
        if (Input.touchCount > 1) return;

        transform.position = Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceToCamera)
        ) + touchOffset;
    }
}
