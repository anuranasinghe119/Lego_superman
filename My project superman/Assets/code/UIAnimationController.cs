using UnityEngine;
using UnityEngine.UI;

public class UIAnimationController : MonoBehaviour
{
    public Button enableButton;
    public Animator animator; 
    public Animator animator2;
    // This method will be called when the UI button is clicked
    public void OnButtonClick()
    {
        if (animator != null)
        {
            animator.SetTrigger("flyOnP"); 
            animator2.SetTrigger("bgGoP");
            enableButton.interactable = false;

        }
        else
        {
            Debug.LogWarning("Animator not assigned to UIAnimationController!");
        }
    }
}
