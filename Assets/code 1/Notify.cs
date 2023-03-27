using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notify : MonoBehaviour
{
    public GameObject Notify_box;
    void Start()
    {
        Notify_box.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("no"))
        {
            Notify_box.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("no"))
        {
            Notify_box.SetActive(false);
        }
    }
}
