using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine.UI;
public class Level_Maneger : MonoBehaviour
{
    public static Level_Maneger instance;
    public static int score;
    //public bool set1; 
    public spawner spawner;
    public spawner spawner1;
    public void Start()
    {
        
    }
    public void Update()
    {
        
    }
    private void Awake() {
        if (instance==null)
        {
            instance = this;
        }    
    }

    // Update is called once per frame
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void AddScore()
    {
        score += 1;
        Debug.Log(score);
    }
    //public void OnTriggerEnter2D(Collider2D other) {
        //if(other.gameObject.CompareTag("Player")){
            
          //  spawner.SpawnerObject();
        //    Level_Maneger.instance.AddScore();
       // } 
   // }

   public void CheckItem(){
        if(score==1){
            spawner.SpawnerObject();
            spawner1.SpawnerObject();
        }
   }
    
    
}
