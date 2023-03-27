using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public delegate void DragEndeDelegate(Draggable draggableObject);

    public DragEndeDelegate dragEndedCallback;

    private bool IsDragged = false ;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;

    private void OnMouseDown(){
        IsDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
    }
    
    private void OnMouseDrag() {
        if(IsDragged){
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        }
    }

    private void OnMouseUp(){
        IsDragged = false;
        dragEndedCallback(this);
    }
}
