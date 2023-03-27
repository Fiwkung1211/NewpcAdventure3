using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapcontroller : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<Draggable> draggableObjects;
    public float snapRange = 0.5f;
    void Start()
    {
        foreach (Draggable draggable in draggableObjects)
        {
            draggable.dragEndedCallback = OnDragEnded;
        }
    }
    private void OnDragEnded(Draggable draggable){
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach(Transform snapPoints in snapPoints){
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoints.localPosition);
            if(closestSnapPoint == null || currentDistance < closestDistance){
                closestSnapPoint = snapPoints;
                closestDistance = currentDistance;
            }
        }
        if(closestSnapPoint != null && closestDistance <= snapRange){
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }
    }
    
}
