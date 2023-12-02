using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDirectionalController : MonoBehaviour
{
    [Range(0f, 180f)][SerializeField] float backAngle = 65f;
    [Range(0f, 180f)][SerializeField] float sideAngle = 155f;
    [SerializeField] Transform mainTransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void LateUpdate()
    {
        Vector3 camForwardVector = new Vector3(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
        Debug.DrawRay(Camera.main.transform.position, camForwardVector * 5f, Color.magenta);

        float signedAngle = Vector3.SignedAngle(mainTransform.forward, camForwardVector, Vector3.up);

        Vector2 animationDirection = new Vector2(0f, -1f);

        float angle = Mathf.Abs(signedAngle);






        if (angle > backAngle)
        {
            // Back animation
            animationDirection = new Vector2(0f, -1f);
        }
        else if (angle < sideAngle)
        {
            /// Right Side animation
            //animationDirection = new Vector2(1f, 0f);

            /// this changes the Side animation based on what side
            /// the camera is viewing the same from.
            
            //if (signedAngle < 0)
            //{
            //    spriteRenderer.flipX = true;
            //}
            //else
            //{
            //    spriteRenderer.flipY = false;
            //}
            
            /// Use this if you have 2 different animations
            /// for the left and right side of the sprite.
            if (signedAngle < 0)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipY = false;
            }
         

        }
        else
        {
            // Front animation
            animationDirection = new Vector2(0f, 1f);
        }

        animator.SetFloat("moveX", animationDirection.x);
        animator.SetFloat("moveY", animationDirection.y);
    }

}
