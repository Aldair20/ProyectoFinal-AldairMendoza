using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPressHandler : MonoBehaviour
{
    public GameObject objetoDesactivar;
    public GameObject objetoActivar;

    private bool isFirstPress = true;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (isFirstPress)
            {
                // Desactiva el primer objeto y activa el segundo
                objetoDesactivar.SetActive(false);
                objetoActivar.SetActive(true);

                isFirstPress = false;
            }
            else
            {
                // Cambia a la escena "Cocina"
                SceneManager.LoadScene("Cocina");
            }
        }
    }
}
