using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererController : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Button enableButton;
    public Button flyone;
    public Button flyoff;
    public Animator animator;
    public float LaserOnDelay = 2.0f;
    public float LaserOffDelay = 2.0f;

    private void Start()
    {
        enableButton.onClick.AddListener(EnableLineRenderer);
    }
    private void EnableLineRenderer()
    {
        StartCoroutine(EnableLineRendererWithDelay());
    }
    
        //return type is not suitable for addlistner so call use above code
    private IEnumerator EnableLineRendererWithDelay()
    {
        enableButton.interactable = false;
        flyone.interactable = false;
        flyoff.interactable = false;
        animator.SetTrigger("laserOn");
        yield return new WaitForSeconds(LaserOnDelay);
        lineRenderer.enabled = true;
        yield return new WaitForSeconds(LaserOffDelay);
        lineRenderer.enabled = false;
        animator.ResetTrigger("laserOn");
        yield return new WaitForSeconds(LaserOnDelay);
        enableButton.interactable = true;
        flyone.interactable = true;
        flyoff.interactable = true;
    }

}
