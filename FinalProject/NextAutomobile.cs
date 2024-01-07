using UnityEngine;
using UnityEngine.UI;

public class NextAutomobile : MonoBehaviour
{
    public GameObject[] objectsToToggle;
    private GameObject currentlyActiveObject;

    public void NextObject()
    {
        if (objectsToToggle != null && objectsToToggle.Length > 0)
        {
            if (currentlyActiveObject != null)
                currentlyActiveObject.SetActive(false);
            int currentIndex = -1;
            if (currentlyActiveObject != null)
                currentIndex = System.Array.IndexOf(objectsToToggle, currentlyActiveObject);
            int nextIndex = (currentIndex + 1) % objectsToToggle.Length;
            currentlyActiveObject = objectsToToggle[nextIndex];
            currentlyActiveObject.SetActive(true);
        }
        else
            Debug.LogError("Please assign GameObjects to objectsToToggle array in the inspector.");
    }
}
