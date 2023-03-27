using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spawner1 : MonoBehaviour
{
    public GameObject objectToSpawn1;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D target) {
        //เก็บไอเท็ม
        
        
        
    }
    //ฟังชั่นสปาวไอเทม
    public void SpawnerObject1(){
        Instantiate(objectToSpawn1, transform.position, objectToSpawn1.transform.rotation);
        }
}
