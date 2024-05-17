using UnityEngine;
using TMPro;

public class PUNTAJEFINAL : MonoBehaviour
{
    public TextMeshProUGUI textoHamburguesasPreparadas;
	public GameObject MUYBIEN;
	public GameObject MUYMAL;
	public GameObject MUYREGULAR;
	public GameObject ESTRELLA1;
	public GameObject ESTRELLA2;
	public GameObject ESTRELLA3;
	public GameObject ESTRELLA4;
	public GameObject ESTRELLA5;
	public AudioSource WIN;
	public AudioSource DRAW;
	public AudioSource LOSE;

    void Start()
    {
        // Recuperar el valor de HamburguesasPreparadas
        int hamburguesasPreparadas = PlayerPrefs.GetInt("HamburguesasPreparadas", 0);

        // Mostrar el valor en un TextMeshProUGUI
        textoHamburguesasPreparadas.text = "Hamburguesas Preparadas: " + hamburguesasPreparadas;
		if(hamburguesasPreparadas==0)
		{
			MUYMAL.SetActive(true);
			LOSE.Play();
		}
		if(hamburguesasPreparadas<=3&&hamburguesasPreparadas>0)
		{
			MUYREGULAR.SetActive(true);
			DRAW.Play();
		}
		if(hamburguesasPreparadas>3)
		{
			MUYBIEN.SetActive(true);
			WIN.Play();
		}
        if (hamburguesasPreparadas > 1)
        {
            ESTRELLA1.SetActive(true);
        }
        if (hamburguesasPreparadas > 3)
        {
            ESTRELLA2.SetActive(true);
        }
        if (hamburguesasPreparadas > 5)
        {
            ESTRELLA3.SetActive(true);
        }
        if (hamburguesasPreparadas > 7)
        {
            ESTRELLA4.SetActive(true);
        }
        if (hamburguesasPreparadas > 9)
        {
            ESTRELLA5.SetActive(true);
        }		
    }
}
