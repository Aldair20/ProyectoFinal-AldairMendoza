using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    private float tiempoInicial = 60.0f; 
    private float tiempoRestante;
    public AudioSource SountrackNormal;
    public AudioSource SountrackAcelerado;
    public AudioSource Finish;
	public GameObject Tiempo;


    private bool unMinutoRestanteNotificado = false;
    private bool tiempoAgotado = false;

    void Start()
    {
        tiempoRestante = tiempoInicial;
        ActualizarCronometro();
		Tiempo.SetActive(false);
    }

    void Update()
    {
        if (!tiempoAgotado)
        {
            if (tiempoRestante > 0.0f)
            {
                tiempoRestante -= Time.deltaTime;
                ActualizarCronometro();

                // Verificar si queda 1 minuto de tiempo restante
                if (tiempoRestante <= 60 && !unMinutoRestanteNotificado)
                {
                    // Poner pausa a SountrackNormal y reproducir SountrackAcelerado
                    SountrackNormal.Pause();
                    SountrackAcelerado.Play();
                    unMinutoRestanteNotificado = true;
                }
            }
            else
            {
                // Se acabó el tiempo
                tiempoAgotado = true;
                tiempoRestante = 0.0f;
                ActualizarCronometro();

                // Poner pausa a SountrackAcelerado y reproducir Finish
                SountrackAcelerado.Stop(); // Detener el sonido acelerado si está en reproducción
                Finish.Play();
				Tiempo.SetActive(true);
            }
        }
    }

    void ActualizarCronometro()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);

        string textoMinutos = minutos.ToString("00");
        string textoSegundos = segundos.ToString("00");

        textoCronometro.text = $"{textoMinutos}:{textoSegundos}";
    }
}
