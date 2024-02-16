using UnityEngine;
using UnityEngine.UI;

public class BoutonScript : MonoBehaviour
{
    public Animator cameraAnimator; // Référence à l'Animator de la caméra

    private void Start()
    {
        // Assurez-vous que la référence à l'Animator est définie dans l'inspecteur
        if (cameraAnimator == null)
        {
            Debug.LogError("Veuillez définir la référence à l'Animator de la caméra dans l'inspecteur.");
        }
    }

    public void ActiverAnimationCamera()
    {
        // Activer l'animation de la caméra
        cameraAnimator.SetTrigger("enter_menu"); // Remplacez "NomDeVotreTrigger" par le nom de votre déclencheur d'animation
    }
}
