using UnityEngine;
using UnityEngine.UI;

public class BoutonScript : MonoBehaviour
{
    public Animator cameraAnimator; // R�f�rence � l'Animator de la cam�ra

    private void Start()
    {
        // Assurez-vous que la r�f�rence � l'Animator est d�finie dans l'inspecteur
        if (cameraAnimator == null)
        {
            Debug.LogError("Veuillez d�finir la r�f�rence � l'Animator de la cam�ra dans l'inspecteur.");
        }
    }

    public void ActiverAnimationCamera()
    {
        // Activer l'animation de la cam�ra
        cameraAnimator.SetTrigger("enter_menu"); // Remplacez "NomDeVotreTrigger" par le nom de votre d�clencheur d'animation
    }
}
