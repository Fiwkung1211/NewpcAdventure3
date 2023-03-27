using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POP : MonoBehaviour
{
    //public GameObject gameObject;  
    void Start()
    {
        gameObject.SetActive(false);
    }
    void update(){
            if(Level_Maneger.score == 1){
                gameObject.SetActive(true);
            }
    }
        public void POPUP(){
            
        }
   
}
