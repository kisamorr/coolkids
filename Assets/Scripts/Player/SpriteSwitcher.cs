using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitcher : MonoBehaviour
{

    public Camera mainCamera;
    public List<Sprite> sprites;
    public SpriteRenderer target;

    //
    public Transform TheCamera;
    public GameObject billboard;

    public bool useAnimator = false;
    public bool use4Directions = true;

    public bool useMirror;
    enum Facing { Up, Right, Down, Left };
    private Facing _facing;
     
    private float angle;                //  variable float is created to monitor the value of an angle
    private float sign = 1;             //  variable to tell if the angle is positive or negative
    private float signAngle;

    private Animator animator;          //  animator variable to get the animator component of the billboard
    private SpriteRenderer _sprite;     //  spriteRenderer variable to assign the sprite renderer script of an object to this code                              
    private Transform _billboard;       //  another transform variable, for the object where the bildboard is                             
    private Transform _t;               //  another transform variable, for the object where this script is
    private Vector3 direction;          //  the direction of the camera is relative to this object
    private bool tOutcome;

    private void OnValidate()
    {
        if (billboard == null)
        {
            Debug.Log("you need to assing the object billboard that has the Animator and Sprite Renderer components to use this script");
        }
        else
        {
            animator = billboard.GetComponent<Animator>();
        }
    }

    private void Awake()
    {
        _t = transform;

        if (billboard != null)
        {   // if we detect the billboard then get the animator, the spriterenderer and transform components in these variables]
            animator = billboard.GetComponent<Animator>();
            _sprite = billboard.GetComponent<SpriteRenderer>();
            _billboard = billboard.transform;

        }
    }
    void Update()
    {
        float angle = Mathf.Repeat(GetCurrentAngle() + Mathf.PI / 4, Mathf.PI * 2);
        int spriteIndex = Mathf.FloorToInt(angle / (2 * Mathf.PI) * sprites.Count);

        if (spriteIndex >= sprites.Count)
        {
            spriteIndex = 0;
        }
        
        target.sprite = sprites[spriteIndex];

        //

        Vector3 forward = _t.forward;
        forward.y = 0;
        Vector3 direction2 = _t.InverseTransformPoint(TheCamera.position);

        sign = (direction2.x >= 0) ? -1 : 1;            // variable to get the sign of the angle (positive or negative)
        angle = Vector3.Angle(direction, forward);      // we use it to know the angle, calculating the smallest angle between the 2 vectors, The result is never greater than 180 degrees
        signAngle = angle * sign;                       // this is to know the full angle from -180 to 180, it can be easily turn into 0 to 360 by just adding 180

        direction = TheCamera.position - _t.position;   // another vector, calculates the relative position of one object (this) to the other (camera)]  
        direction.y = 0;                                // 0 in the "Y" axis of the 3D vector "direction" to make it a 2D vector on X,Z]
        _billboard.rotation = Quaternion.LookRotation(-direction, _t.up);   // use the inverse of the targetpoint vector and the upwards vector of THIS object, to create a quaternion to look at the rotation of this vectors, then order the billboard to follow this same rotation]
        
        if (useMirror)
        {
            Mirror();
        }
        else
        {
            _sprite.flipX = false;  //if you are using animation dont worry, the animatior overrides spriteRenderer coming from a code like this
        }


        if (use4Directions == false)
        {
            if (animator.isActiveAndEnabled == true)
            {
                animator.SetInteger("direction", (int)_facing); // the value of the facing operation is send to the parameter 'direction' in the animatorController of the billboard object]
            }
            else
            {
                _sprite.sprite = sprites[(int)_facing];         // the value of the facing operation is used to select a sprite from the list 'sprites' and render it in the spriteRenderer component]
            }
        }
        else if (use4Directions == true)
        {
            if (animator.isActiveAndEnabled == true)
            {
                animator.SetInteger("direction", (int)_facing); // the value of the facing operation is send to the parameter 'direction' in the animatorController of the billboard object]
            }
            else
            {
                _sprite.sprite = sprites[(int)_facing / 2];     // the value of the facing operation is divided by 2...  facing can only be [0,2,4,6] thanks to "use 4 directions" and divided by 2 we get [0,1,2,3] to fit the small list]
            }
        }


    }

    public virtual void LateUpdate()
    {
        if(use4Directions == true)
        {
            if(angle < 45.0f)
            {
                _facing = Facing.Up;     // 0-45 degrees
            }
            else if(angle < 135.0f)
            {
                _facing = sign < 0 ? Facing.Right : Facing.Left; //if the value is positive then facing is Right, if the value is negative facing changes to Left
            }
            else
            {
                _facing = Facing.Down; // character shows back
            }
        }
    }

    public void Mirror()
    {
        if (use4Directions == true)
        {
            switch(_facing)
            {
                case Facing.Left:               // if facing left is detected then change the sprite to render right and flip the sprite horizontally
                    _facing = Facing.Right;
                    _sprite.flipX = true;
                    break;

                    default:                    // if none of these cases are detected then don't flip the sprite
                    _sprite.flipX = false;
                    break;
            }
        }
    }

    float GetCurrentAngle()
    {
        Vector3 playerDirWorld = transform.forward;
        Vector3 playerDirCam = mainCamera.transform.worldToLocalMatrix.MultiplyPoint(playerDirWorld);
        return Mathf.Atan2(playerDirCam.x, playerDirCam.y);
    }

}
