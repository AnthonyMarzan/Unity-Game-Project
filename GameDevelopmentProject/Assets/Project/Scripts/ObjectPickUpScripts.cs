using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPickUpScripts : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //when a golden orb gets taken add 100 to score
        if (gameObject.CompareTag("PickUps"))
        {
            Singleton.Instance.AdjustScore(100);
            gameObject.SetActive(false);
        }

        //when a red orb is taken, reduce jump stats
        if (gameObject.CompareTag("PowerDown"))
        {
            other.gameObject.GetComponent<Invector.CharacterController.vThirdPersonMotor>().freeRunningSpeed = 2.0f;
            other.gameObject.GetComponent<Invector.CharacterController.vThirdPersonMotor>().freeSprintSpeed = 2.5f;
            gameObject.SetActive(false);
        }

        //when a green orb is taken, normalize jump stats
        if (gameObject.CompareTag("PowerUp"))
        {
            other.gameObject.GetComponent<Invector.CharacterController.vThirdPersonMotor>().freeRunningSpeed = 4.0f;
            other.gameObject.GetComponent<Invector.CharacterController.vThirdPersonMotor>().freeSprintSpeed = 5f;
            //          other.gameObject.GetComponent<Invector.CharacterController.vThirdPersonMotor>().jumpForward = 5.0f;
            //          other.gameObject.GetComponent<Invector.CharacterController.vThirdPersonMotor>().jumpHeight = 7.0f;
            gameObject.SetActive(false);
        }
    }
}
