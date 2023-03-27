//ไลบารี่ของเกม
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Redhat3_test_controller : MonoBehaviour
{
    AudioSource jumpsound;//ตัวเเปรเสียงกระโดด
    public float speed; //ตัวเเปรความเร็ววิ่ง
    int jump; //ตัวเเปรกระโดด
    int jumpRate = 2; //จำนวนครั้งในการกระโดด
    float x, sx;
    bool ks;
    Animator am;
    Rigidbody2D rb;
    //โค้ดส่วน start
    void Start()
    {
        jump = 0;
        am = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sx = transform.localScale.x;
        jumpsound=GetComponent<AudioSource>();
    }

    //โค้ดส่วน update
    void Update()
    {
         x = Input.GetAxis ("Horizontal");
        am.SetFloat("speed", Abs(x));
        //โค้ดกระโดด
    if (Input.GetButtonDown("Jump") && jump < jumpRate)
        
        if (Input.GetButtonDown ("Jump"))
        {
            //โค้ดเสียงกระโดด
           jumpsound.Play();
            //โค้ดเสียงกระโดด
            jump++;
            am.SetBool("jump", true);
            rb.velocity = new Vector2 (rb.velocity.x, 5f);
        }
        //โค้ดเดิน
        rb.velocity = new Vector2 (x * speed, rb.velocity.y);
        if (x > 0)
        {
            transform.localScale = new Vector3 (sx, transform.localScale.y, transform.localScale.z);
        }
        if (x < 0)
        {
            transform.localScale = new Vector3 (-sx, transform.localScale.y, transform.localScale.z);
        }

    }
    //ฟังชั่นกระโดด
    void OnCollisionEnter2D(Collision2D coll)
    {
        am.SetBool("jump", false);
        jump = 0;
    }
    float Abs(float x)
    {
        return x >= 0f ? x : -x;
    }
    public void OnTriggerEnter2D(Collider2D target) {
        //โค้ดรีสตราทเกม
        if (target.gameObject.CompareTag("KillPlane"))
        {
            RestartGame();
        }
        //โค้ดรีสตราทเกม

        //โค้ดไปด่านต่อไป
        if (target.gameObject.CompareTag("COM1_to_CPU"))
        {
            SceneManager.LoadScene("2_CPU");
        }
        if (target.gameObject.CompareTag("CPU_To_MB"))
        {
            SceneManager.LoadScene("3_board");
        }

        if (target.gameObject.CompareTag("MB_To_VGA"))
        {
            SceneManager.LoadScene("4_VGA");
        }  

        if (target.gameObject.CompareTag("Vga_To_Ram"))
        {
            SceneManager.LoadScene("5_Ram");
        }   

        if (target.gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene("6_Harddisk");
        }
        
        if (target.gameObject.CompareTag("Hard_To_PW"))
        {
            SceneManager.LoadScene("7_Power");
        } 
        if (target.gameObject.CompareTag("PW_To_case"))
        {
            SceneManager.LoadScene("8_case");
        }
        if (target.gameObject.CompareTag("Case_to_COM9")){
            SceneManager.LoadScene("9.1_Computer");
        }         
        if (target.gameObject.CompareTag("COM9_to_10")){
            SceneManager.LoadScene("10");
        }
        if (target.gameObject.CompareTag("item")){
            Destroy(target.gameObject);
        } 
    }

    //โค้ดรีสตราทเกม
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //โค้ดรีสตราทเกม
    
}

