using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    [SerializeField] bool freezeXZaxis = true;

    // LateUpdate = camera is updated first.
    private void LateUpdate()
    {
        if (freezeXZaxis)
        {
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
            // takes in 3 floats that change the transform/rotation of whatever this script is attached to.
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
            // copying the exact angles of the camera to object's transform.
            // good for topdown views.
        }
    }
}
