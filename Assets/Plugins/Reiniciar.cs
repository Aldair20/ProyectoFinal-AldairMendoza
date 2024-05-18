using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonToInicio : MonoBehaviour
{
    void Update()
    {
        // Verificar si se presiona cualquier tecla
        if (Input.anyKeyDown)
        {
            // Esperar a que se suelte el botón
            StartCoroutine(WaitForButtonRelease());
        }
    }

    private System.Collections.IEnumerator WaitForButtonRelease()
    {
        // Esperar a que se suelte el botón
        yield return new WaitUntil(() => Input.anyKey == false);

        // Transportar a la escena "Inicio"
        SceneManager.LoadScene("Inicio");
    }
}
