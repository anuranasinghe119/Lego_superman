using UnityEngine;

public class UIAnimationController : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public Animator animator2;
    // This method will be called when the UI button is clicked
    public void OnButtonClick()
    {
        if (animator != null)
        {
            animator.SetTrigger("flyOnP"); 

            animator2.SetTrigger("bgGoP");

        }
        else
        {
            Debug.LogWarning("Animator not assigned to UIAnimationController!");
        }
    }
}
