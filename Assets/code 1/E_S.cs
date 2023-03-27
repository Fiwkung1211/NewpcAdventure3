using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class E_S : MonoBehaviour
{
    public GameObject Chat_textbox;
    void Start()
    {
        Chat_textbox.SetActive(false);
    }
    public void Op_Chat()
    {
        Chat_textbox.SetActive(true);
        AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        Time.timeScale = 0f;
    }

    public void Co_Chat()
    {
        Chat_textbox.SetActive(false);
        Time.timeScale = 1f;
    }
    //กดเพื่อโหลดด่าน Mainboard
    public void LoadScene_MB1(){
        SceneManager.LoadScene("3.1_board");
    }
    public void LoadScene_MB2(){
        SceneManager.LoadScene("3.2_board");
    }
    public void LoadScene_MB3(){
        SceneManager.LoadScene("3.3_board");
    }
    public void LoadScene_MB4(){
        SceneManager.LoadScene("3.4_board");
    }
    //กดเพื่อโหลดด่าน VGA
    public void LoadScene_VGA1(){
        SceneManager.LoadScene("4.1_VGA");
    }
    public void LoadScene_VGA2(){
        SceneManager.LoadScene("4.2_VGA");
    }
    public void LoadScene_VGA3(){
        SceneManager.LoadScene("4.3_VGA");
    }
    public void LoadScene_VGA4(){
        SceneManager.LoadScene("4.4_VGA");
    }

    //กดเพื่อโหลดด่าน Ram
    public void LoadScene_RAM1(){
        SceneManager.LoadScene("5.1_Ram");
    }
    public void LoadScene_RAM2(){
        SceneManager.LoadScene("5.2_Ram");
    }
    public void LoadScene_RAM3(){
        SceneManager.LoadScene("5.3_Ram");
    }
    public void LoadScene_RAM4(){
        SceneManager.LoadScene("5.4_Ram");
    }

    //กดเพื่อโหลดด่าน Harddisk
    public void LoadScene_HD1(){
        SceneManager.LoadScene("6.1_Harddisk");
    }
    public void LoadScene_HD2(){
        SceneManager.LoadScene("6.2_Harddisk");
    }
    public void LoadScene_HD3(){
        SceneManager.LoadScene("6.3_Harddisk");
    }
    public void LoadScene_HD4(){
        SceneManager.LoadScene("6.4_Harddisk");
    }

    //กดเพื่อโหลดด่าน Power Supply
    public void LoadScene_PW1(){
        SceneManager.LoadScene("7.1_Power");
    }
    public void LoadScene_PW2(){
        SceneManager.LoadScene("7.2_Power");
    }
    public void LoadScene_PW3(){
        SceneManager.LoadScene("7.3_Power");
    }
    public void LoadScene_PW4(){
        SceneManager.LoadScene("7.4_Power");
    }

    //กดเพื่อโหลดด่าน Power Supply
    public void LoadScene_Case1(){
        SceneManager.LoadScene("8.1_case");
    }
    public void LoadScene_Case2(){
        SceneManager.LoadScene("8.2_case");
    }
    public void LoadScene_Case3(){
        SceneManager.LoadScene("8.3_case");
    }
    public void LoadScene_Case4(){
        SceneManager.LoadScene("8.4_case");
    }

    //กดเพื่อโหลดด่าน Computer
    public void LoadScene_com1(){
        SceneManager.LoadScene("9.1_Computer");
    }
    public void LoadScene_com2(){
        SceneManager.LoadScene("9.2_Computer");
    }
    public void LoadScene_com3(){
        SceneManager.LoadScene("9.3_Computer");
    }
    public void LoadScene_com4(){
        SceneManager.LoadScene("9.4_Computer");
    }
}
