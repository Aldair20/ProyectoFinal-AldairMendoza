using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonToInicio : MonoBehaviour
{
    void Update()
    {
        // Verificar si se ha presionado cualquier botón del mando
        if (Input.anyKeyDown)
        {
            // Cambiar a la escena "Inicio"
            SceneManager.LoadScene("Inicio");
        }
    }
}
