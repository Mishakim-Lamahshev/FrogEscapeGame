using UnityEngine;

public class FrogController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Distance of each leap")]
    private float leapDistance = 2f;

    private void Update()
    {
        Leap();
    }

    private void Leap()
    {
        Vector3 leapDirection = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            leapDirection = Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            leapDirection = Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leapDirection = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            leapDirection = Vector3.right;
        }

        // Apply the leap
        transform.position += leapDirection * leapDistance;
    }
}
