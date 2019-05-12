using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAndMouseScript : MonoBehaviour
{
    public GameObject uiObject;

    private void Start()
    {
        uiObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("Player"))
        {
            uiObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            uiObject.SetActive(false);
        }
    }
}
