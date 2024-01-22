using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component goes to given scene whenever it triggers a 2D collider with the given tag.
 */
public class GoToSceneOnTrigger2D : MonoBehaviour
{
    [Tooltip("Scene to go to")]
    [SerializeField] string sceneName;

    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
