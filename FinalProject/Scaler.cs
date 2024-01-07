using UnityEngine;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{
    public GameObject[] objectsToScale;
    public void Upscale()
    {
        for(int i=0; i<objectsToScale.Length; i++)
            objectsToScale[i].transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
    public void Downscale()
    {
        for(int i=0; i<objectsToScale.Length; i++)
            objectsToScale[i].transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }
}
