using UnityEngine;
using System.Collections;

namespace Invector.CharacterController
{
    public class vThirdPersonController : vThirdPersonAnimator
    {

        protected virtual void Start()
        {
#if !UNITY_EDITOR
                Cursor.visible = false;
#endif
        }

        public virtual void Sprint(bool value)
        {                                   
            isSprinting = value;            
        }

        public virtual void Strafe()
        {
            if (locomotionType == LocomotionType.OnlyFree) return;
            isStrafing = !isStrafing;
        }

        public virtual void Jump()
        {
            // conditions to do this action
            bool jumpConditions = isGrounded && !isJumping;
            // return if jumpCondigions is false
            if (!jumpConditions) return;
            // trigger jump behaviour
            jumpCounter = jumpTimer;            
            isJumping = true;
            // trigger jump animations            
            if (_rigidbody.velocity.magnitude < 1)
                animator.CrossFadeInFixedTime("Jump", 0.1f);
            else
                animator.CrossFadeInFixedTime("JumpMove", 0.2f);
        }

        public virtual void RotateWithAnotherTransform(Transform referenceTransform)
        {
            var newRotation = new Vector3(transform.eulerAngles.x, referenceTransform.eulerAngles.y, transform.eulerAngles.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(newRotation), strafeRotationSpeed * Time.fixedDeltaTime);
            targetRotation = transform.rotation;
        }
/*
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("PickUps"))
            {
                Singleton.Instance.AdjustScore(100);
                other.gameObject.SetActive(false);
            }

            if (other.gameObject.CompareTag("PowerDown"))
            {
                freeRunningSpeed = 2.0f;
                freeSprintSpeed = 2.5f;
                powerDown = true;
                other.gameObject.SetActive(false);
            }

            if (other.gameObject.CompareTag("PowerUp"))
            {
                jumpForward = 5.0f;
                jumpHeight = 7.0f;
                other.gameObject.SetActive(false);
            }
        }

        private void Update()
        {
            if(powerDown)
            {
                powerDownTime -= Time.deltaTime;
                if (powerDownTime < 0)
                {
                    freeRunningSpeed = 4.0f;
                    freeSprintSpeed = 5.0f;
                }
            }

            if (powerUp)
            {
                powerUpTime -= Time.deltaTime;
                if (powerUpTime < 0)
                {
                    jumpForward = 3.0f;
                    jumpHeight = 5.0f;
                }
            }

        }*/
    }
}