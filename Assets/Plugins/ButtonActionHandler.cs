using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActionHandler : MonoBehaviour
{
    public GameObject objectToActivate; // Objeto que se activará al soltar el primer botón
    public GameObject objectToDeactivate; // Objeto que se desactivará al soltar el primer botón
    private bool isFirstButtonPressed = false; // Bandera para verificar si ya se presionó el primer botón

    void Update()
    {
        // Verificar si se presiona cualquier tecla
        if (Input.anyKeyDown)
        {
            // Si el primer botón no se ha presionado
            if (!isFirstButtonPressed)
            {
                // Esperar a que se suelte el botón
                StartCoroutine(WaitForButtonRelease());
            }
            // Si el primer botón ya se presionó, esperar a que se suelte el segundo botón
            else
            {
                // Esperar a que se suelte el botón
                StartCoroutine(WaitForSecondButtonRelease());
            }
        }
    }

    private System.Collections.IEnumerator WaitForButtonRelease()
    {
        // Esperar a que se suelte el botón
        yield return new WaitUntil(() => Input.anyKey == false);

        // Activar el objeto
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }

        // Desactivar el objeto
        if (objectToDeactivate != null)
        {
            objectToDeactivate.SetActive(false);
        }

        // Marcar que el primer botón se ha presionado
        isFirstButtonPressed = true;
    }

    private System.Collections.IEnumerator WaitForSecondButtonRelease()
    {
        // Esperar a que se suelte el botón
        yield return new WaitUntil(() => Input.anyKey == false);

        // Transportar a la escena "Cocina"
        SceneManager.LoadScene("Cocina");
    }
}
