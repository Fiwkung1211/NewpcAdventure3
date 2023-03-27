using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D target) {
        //เก็บไอเท็ม
        
        if (target.gameObject.CompareTag("item")){
            Destroy(target.gameObject);

        } 
    }
    //ฟังชั่นสปาวไอเทม
    public void SpawnerObject(){
        Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
    }
}
