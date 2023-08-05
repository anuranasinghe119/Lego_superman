using UnityEngine;
using UnityEngine.UI;

public class UIAnimationController1 : MonoBehaviour
{
    public Button enableButton;
    public Animator animator; 
    public Animator animator2;
    // This method will be called when the UI button is clicked
    public void OnButtonClick()
    {
        if (animator != null)
        {
            animator.ResetTrigger("flyOnP"); 
            animator2.ResetTrigger("bgGoP");
            enableButton.interactable = true;

        }
        else
        {
            Debug.LogWarning("Animator not assigned to UIAnimationController!");
        }
    }
}
