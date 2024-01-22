using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component goes to given scene whenever it triggers a 2D collider with the given tag.
 */
public class GoToStartOnTrigger2D : MonoBehaviour
{
    [Tooltip("Starting point")]
    [SerializeField] Vector3 startingPoint;

    [Tooltip("Every object tagged with this tag will trigger going back to starting point")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            transform.position = startingPoint;
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
