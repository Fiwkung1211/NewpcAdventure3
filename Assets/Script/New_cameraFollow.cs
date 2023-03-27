using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_cameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform target;
    public float yoffset =1f;
   
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x,target.position.y + yoffset,-10f);
        transform.position = Vector3.Slerp(transform.position,newPos,FollowSpeed*Time.deltaTime);
    }
}
