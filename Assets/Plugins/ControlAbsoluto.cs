using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class ContadorCarnes : MonoBehaviour
{
    // Inicializar el contador en 10 cada ingrediente
	public int ingredienteCarnes = 10; 
	public int ingredienteCebolla = 10; 
	public int ingredienteJitomate = 10; 
	public int ingredienteLechuga = 10; 
	public int ingredientePapa = 10; 
	public int ingredienteQueso = 10;  
    public int ingredienteRefrescos = 10;
	// Arreglo para almacenar los 10 objetos de cada ingrediente
    public GameObject[] objetosCarnes; 
	public GameObject[] objetosCebolla;
	public GameObject[] objetosJitomate;
	public GameObject[] objetosLechuga;
	public GameObject[] objetosPapa;
	public GameObject[] objetosQueso;
	public GameObject[] objetosRefrescos;
	
	public AudioSource Correct;
	public AudioSource Bebop;
	public AudioSource YEEEI;

	
    private bool teclaPresionada = false; // Variable para controlar si ya se presionó una tecla en este frame
	
    public GameObject jugador; // Variable para almacenar el objeto Player
	public GameObject PuertaRefri; // Variable para almacenar el objeto Player
	public GameObject objetoRefresco; // Variable para almacenar el objeto RefrescoPreparado
	public GameObject ComboPapas1; // Variable para almacenar el Combo papas 1
	public GameObject ComboPapas2; // Variable para almacenar el Combo papas 2
	public GameObject ComboPapas3; // Variable para almacenar el Combo papas 3
	public GameObject ComboPapas4; // Variable para almacenar el Combo papas 4
	public GameObject ComboPapas5; // Variable para almacenar el Combo papas 5
	public GameObject ComboPapas6; // Variable para almacenar el Combo papas 6
	public GameObject ComboPapas7; // Variable para almacenar el Combo papas 7
	public GameObject ComboPapas8; // Variable para almacenar el Combo papas 8
	public GameObject Lechuga1; // Variable para almacenar la lechuga 1
	public GameObject Lechuga2; // Variable para almacenar la lechuga 2
	public GameObject Lechuga3; // Variable para almacenar la lechuga 3
	public GameObject Lechuga4; // Variable para almacenar la lechuga 4
	public GameObject Lechuga5; // Variable para almacenar la lechuga 5
	public GameObject Lechuga6; // Variable para almacenar la lechuga 6
	public GameObject Lechuga7; // Variable para almacenar la lechuga 7
	public GameObject Lechuga8; // Variable para almacenar la lechuga 8
	public GameObject Queso1; // Variable para almacenar el queso 1
	public GameObject Queso2; // Variable para almacenar el queso 2
	public GameObject Queso3; // Variable para almacenar el queso 3
	public GameObject Queso4; // Variable para almacenar el queso 4
	public GameObject Queso5; // Variable para almacenar el queso 5
	public GameObject Queso6; // Variable para almacenar el queso 6
	public GameObject Queso7; // Variable para almacenar el queso 7
	public GameObject Queso8; // Variable para almacenar el queso 8
	public GameObject Carne1; // Variable para almacenar la carne 1
	public GameObject Carne2; // Variable para almacenar la carne 2
	public GameObject Carne3; // Variable para almacenar la carne 3
	public GameObject Carne4; // Variable para almacenar la carne 4
	public GameObject Carne5; // Variable para almacenar la carne 5
	public GameObject Carne6; // Variable para almacenar la carne 6
	public GameObject Carne7; // Variable para almacenar la carne 7
	public GameObject Carne8; // Variable para almacenar la carne 8
	public GameObject Cebolla1; // Variable para almacenar la cebolla 1
	public GameObject Cebolla2; // Variable para almacenar la cebolla 2
	public GameObject Cebolla3; // Variable para almacenar la cebolla 3
	public GameObject Cebolla4; // Variable para almacenar la cebolla 4
	public GameObject Cebolla5; // Variable para almacenar la cebolla 5
	public GameObject Cebolla6; // Variable para almacenar la cebolla 6
	public GameObject Cebolla7; // Variable para almacenar la cebolla 7
	public GameObject Cebolla8; // Variable para almacenar la cebolla 8
	public GameObject Jitomate1; // Variable para almacenar el jitomate 1
	public GameObject Jitomate2; // Variable para almacenar el jitomate 2
	public GameObject Jitomate3; // Variable para almacenar el jitomate 3
	public GameObject Jitomate4; // Variable para almacenar el jitomate 4
	public GameObject Jitomate5; // Variable para almacenar el jitomate 5
	public GameObject Jitomate6; // Variable para almacenar el jitomate 6
	public GameObject Jitomate7; // Variable para almacenar el jitomate 7
	public GameObject Jitomate8; // Variable para almacenar el jitomate 8
	public GameObject TapaderaPan1; // Variable para almacenar la tapa de pan 1
	public GameObject TapaderaPan2; // Variable para almacenar la tapa de pan 2
	public GameObject TapaderaPan3; // Variable para almacenar la tapa de pan 3
	public GameObject TapaderaPan4; // Variable para almacenar la tapa de pan 4
	public GameObject TapaderaPan5; // Variable para almacenar la tapa de pan 5
	public GameObject TapaderaPan6; // Variable para almacenar la tapa de pan 6
	public GameObject TapaderaPan7; // Variable para almacenar la tapa de pan 7
	public GameObject TapaderaPan8; // Variable para almacenar la tapa de pan 8
	public GameObject TapaderaPan9; // Variable para almacenar la tapa de pan 9

	private int indicePapas=0;
	private int indiceHamburguesa=0;

	public GameObject Mal; // Tache
	public GameObject BienHecho; // Estrella
	
	private bool puertaAbierta = false; // Variable para controlar si la puerta está abierta
	public float velocidadCierre = 2.0f;
	
	public GameObject[] elementos;
    public int[] ArregloDelJugador = new int[7];
	public int[] secuenciaAleatoria = new int[7];
    public float tiempoEntreSecuencias = 1.0f; // Tiempo de espera entre secuencias
	private bool ultimoIndiceSeleccionado = false;
	private int indiceElemento;
	private int indiceJugador=0;
	private int longitudSecuencia;
	private bool jugable = false; // Variable para controlar si ya se presionó una tecla en este frame
	
	public TextMeshProUGUI textoPasos;
	public TextMeshProUGUI HamburguesasHechas;
	private int NumPasos=0;
	private int HamburguesasPreparadas=0;
	
	public GameObject objetoAControlar; // Variable para almacenar el objeto que se va a activar y desactivar
	private bool condicionCumplida = false; // Variable para controlar si se ha cumplido alguna condición
	
	private float tiempoInicial = 307; // 5 minutos y 5 segundos
	private float tiempoTranscurrido = 0f;
    private bool tiempoJugable = true;

    void Start()
    {
        // Obtener referencias a los objetos de ingredientes en la escena
        objetosCarnes = new GameObject[10];
		objetosCebolla = new GameObject[10];
		objetosJitomate = new GameObject[10];
		objetosLechuga = new GameObject[10];
		objetosPapa = new GameObject[10];
		objetosQueso = new GameObject[10];
		objetosRefrescos = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            objetosCarnes[i] = GameObject.Find("Hamburguesa (" + i + ")");
            objetosCebolla[i] = GameObject.Find("Cebolla (" + i + ")");
            objetosJitomate[i] = GameObject.Find("Jitomate (" + i + ")");
            objetosLechuga[i] = GameObject.Find("Lechuga (" + i + ")");
            objetosPapa[i] = GameObject.Find("Papa (" + i + ")");
            objetosQueso[i] = GameObject.Find("Queso (" + i + ")");
            objetosRefrescos[i] = GameObject.Find("VasoRefresco (" + i + ")");
        }
		// Obtener referencia al objeto puerta
        PuertaRefri = GameObject.Find("PuertaRefrigerador");
		// Desactivar todos los elementos al iniciar
        foreach (GameObject elemento in elementos)
        {
            elemento.SetActive(false);
        }
		// Desactivar todos los elementos al iniciar
        objetoAControlar.SetActive(false);
		Mal.SetActive(false);
		BienHecho.SetActive(false);
        StartCoroutine(RealizarSecuencia());
		objetoRefresco.SetActive(false);
		ComboPapas1.SetActive(false);
		ComboPapas2.SetActive(false);
		ComboPapas3.SetActive(false);
		ComboPapas4.SetActive(false);
		ComboPapas5.SetActive(false);
		ComboPapas6.SetActive(false);
		ComboPapas7.SetActive(false);
		ComboPapas8.SetActive(false);
		// Desactivar todas las lechugas
		Lechuga1.SetActive(false);
		Lechuga2.SetActive(false);
		Lechuga3.SetActive(false);
		Lechuga4.SetActive(false);
		Lechuga5.SetActive(false);
		Lechuga6.SetActive(false);
		Lechuga7.SetActive(false);
		Lechuga8.SetActive(false);
		
		// Desactivar todos los quesos
		Queso1.SetActive(false);
		Queso2.SetActive(false);
		Queso3.SetActive(false);
		Queso4.SetActive(false);
		Queso5.SetActive(false);
		Queso6.SetActive(false);
		Queso7.SetActive(false);
		Queso8.SetActive(false);
		
		// Desactivar todas las carnes
		Carne1.SetActive(false);
		Carne2.SetActive(false);
		Carne3.SetActive(false);
		Carne4.SetActive(false);
		Carne5.SetActive(false);
		Carne6.SetActive(false);
		Carne7.SetActive(false);
		Carne8.SetActive(false);
		// Desactivar todas las cebollas
		Cebolla1.SetActive(false);
		Cebolla2.SetActive(false);
		Cebolla3.SetActive(false);
		Cebolla4.SetActive(false);
		Cebolla5.SetActive(false);
		Cebolla6.SetActive(false);
		Cebolla7.SetActive(false);
		Cebolla8.SetActive(false);
		// Desactivar todos los jitomates
		Jitomate1.SetActive(false);
		Jitomate2.SetActive(false);
		Jitomate3.SetActive(false);
		Jitomate4.SetActive(false);
		Jitomate5.SetActive(false);
		Jitomate6.SetActive(false);
		Jitomate7.SetActive(false);
		Jitomate8.SetActive(false);
		// Desactivar todas las tapas de pan
		TapaderaPan1.SetActive(true);
		TapaderaPan2.SetActive(false);
		TapaderaPan3.SetActive(false);
		TapaderaPan4.SetActive(false);
		TapaderaPan5.SetActive(false);
		TapaderaPan6.SetActive(false);
		TapaderaPan7.SetActive(false);
		TapaderaPan8.SetActive(false);
		TapaderaPan9.SetActive(false);
		indiceJugador=0;
		indiceHamburguesa=0;
    }

	IEnumerator RealizarSecuencia()
    {
        // Generar una secuencia aleatoria de longitud aleatoria entre 3 y 7
        longitudSecuencia = Random.Range(3, 8);
        
		//Limpiamos el arreglo
		for (int i = 0; i < longitudSecuencia; i++)
        {
			ArregloDelJugador[i]=0;
		}
		for (int i = 0; i < longitudSecuencia; i++)
        {
			secuenciaAleatoria[i]=0;
		}
		
		yield return new WaitForSeconds(4.0f);
		objetoRefresco.SetActive(false);
		ComboPapas1.SetActive(false);
		ComboPapas2.SetActive(false);
		ComboPapas3.SetActive(false);
		ComboPapas4.SetActive(false);
		ComboPapas5.SetActive(false);
		ComboPapas6.SetActive(false);
		ComboPapas7.SetActive(false);
		ComboPapas8.SetActive(false);
		// Desactivar todas las lechugas
		Lechuga1.SetActive(false);
		Lechuga2.SetActive(false);
		Lechuga3.SetActive(false);
		Lechuga4.SetActive(false);
		Lechuga5.SetActive(false);
		Lechuga6.SetActive(false);
		Lechuga7.SetActive(false);
		Lechuga8.SetActive(false);
		
		// Desactivar todos los quesos
		Queso1.SetActive(false);
		Queso2.SetActive(false);
		Queso3.SetActive(false);
		Queso4.SetActive(false);
		Queso5.SetActive(false);
		Queso6.SetActive(false);
		Queso7.SetActive(false);
		Queso8.SetActive(false);
		
		// Desactivar todas las carnes
		Carne1.SetActive(false);
		Carne2.SetActive(false);
		Carne3.SetActive(false);
		Carne4.SetActive(false);
		Carne5.SetActive(false);
		Carne6.SetActive(false);
		Carne7.SetActive(false);
		Carne8.SetActive(false);
		// Desactivar todas las cebollas
		Cebolla1.SetActive(false);
		Cebolla2.SetActive(false);
		Cebolla3.SetActive(false);
		Cebolla4.SetActive(false);
		Cebolla5.SetActive(false);
		Cebolla6.SetActive(false);
		Cebolla7.SetActive(false);
		Cebolla8.SetActive(false);
		// Desactivar todos los jitomates
		Jitomate1.SetActive(false);
		Jitomate2.SetActive(false);
		Jitomate3.SetActive(false);
		Jitomate4.SetActive(false);
		Jitomate5.SetActive(false);
		Jitomate6.SetActive(false);
		Jitomate7.SetActive(false);
		Jitomate8.SetActive(false);
		// Desactivar todas las tapas de pan
		TapaderaPan1.SetActive(true);
		TapaderaPan2.SetActive(false);
		TapaderaPan3.SetActive(false);
		TapaderaPan4.SetActive(false);
		TapaderaPan5.SetActive(false);
		TapaderaPan6.SetActive(false);
		TapaderaPan7.SetActive(false);
		TapaderaPan8.SetActive(false);
		TapaderaPan9.SetActive(false);
		indiceJugador=0;
		indiceHamburguesa=0;
		indicePapas=0;
		BienHecho.SetActive(false);
		Mal.SetActive(false);
		NumPasos = longitudSecuencia;
		yield return new WaitForSeconds(1.0f);
        for (int i = 0; i < longitudSecuencia; i++)
        {
            // Generar un índice aleatorio para elegir un elemento
            indiceElemento = Random.Range(0, 7);
			if(indiceElemento==7)
			{
				indiceElemento--;
			}
			if(indiceElemento<=5)
			{
				secuenciaAleatoria[i] = indiceElemento;
			}
			if (6==indiceElemento && ultimoIndiceSeleccionado)
			{
				indiceElemento = Random.Range(0, 5);
				secuenciaAleatoria[i] = indiceElemento;
			}
			if (6==indiceElemento && !ultimoIndiceSeleccionado)
			{
				secuenciaAleatoria[i] = indiceElemento;
				ultimoIndiceSeleccionado = true;
			}
            // Activar el elemento correspondiente
            elementos[indiceElemento].SetActive(true);

            // Esperar un segundo antes de pasar al siguiente elemento
            yield return new WaitForSeconds(1.0f);

            // Desactivar el elemento
            elementos[indiceElemento].SetActive(false);

            // Esperar un momento antes de iniciar la siguiente secuencia
            yield return new WaitForSeconds(tiempoEntreSecuencias);
        }
		jugable = true;

    }
	
	

    void Update()
    {
        Vector3 rotacionPlayer = jugador.transform.rotation.eulerAngles;
		Vector3 rotacionRefri = PuertaRefri.transform.rotation.eulerAngles;
		// Restablecer la condición de cumplimiento a falso
        condicionCumplida = false;
		// Consumo de alimentos al dar click
        // Verificar si se ha detectado alguna entrada (tecla, botón o toque) y la rotación es la deseada
        if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable &&
            rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 327.39f && rotacionPlayer.y <= 339.67f)
        {
            // Reducir el contador si es mayor que 0
            if (ingredienteCarnes > 0)
            {
                ingredienteCarnes--; // Reducir el contador en 1
				ArregloDelJugador[indiceJugador]=2;
				if (ArregloDelJugador[indiceJugador]!= secuenciaAleatoria[indiceJugador])
				{
					Mal.SetActive(true);
					Bebop.Play();
					jugable = false;
					StartCoroutine(RealizarSecuencia());
				}
				else
				{
					indiceHamburguesa++;
					if(indiceHamburguesa==1)
					{
						Carne1.SetActive(true);
						TapaderaPan1.SetActive(false);
						TapaderaPan2.SetActive(true);
						
					}
					if(indiceHamburguesa==2)
					{
						Carne2.SetActive(true);
						TapaderaPan2.SetActive(false);
						TapaderaPan3.SetActive(true);
					}
					if(indiceHamburguesa==3)
					{
						Carne3.SetActive(true);
						TapaderaPan3.SetActive(false);
						TapaderaPan4.SetActive(true);
					}
					if(indiceHamburguesa==4)
					{
						Carne4.SetActive(true);
						TapaderaPan4.SetActive(false);
						TapaderaPan5.SetActive(true);
					}
					if(indiceHamburguesa==5)
					{
						Carne5.SetActive(true);
						TapaderaPan5.SetActive(false);
						TapaderaPan6.SetActive(true);
					}
					if(indiceHamburguesa==6)
					{
						Carne6.SetActive(true);
						TapaderaPan6.SetActive(false);
						TapaderaPan7.SetActive(true);
					}
					if(indiceHamburguesa==7)
					{
						Carne7.SetActive(true);
						TapaderaPan7.SetActive(false);
						TapaderaPan8.SetActive(true);
					}
					if(indiceHamburguesa==8)
					{
						Carne8.SetActive(true);
						TapaderaPan8.SetActive(false);
						TapaderaPan9.SetActive(true);
					}
					indiceJugador++;
					if(indiceJugador<longitudSecuencia)
					{
						Correct.Play();
					}
					if(indiceJugador==longitudSecuencia)
					{
						BienHecho.SetActive(true);
						YEEEI.Play();
						HamburguesasPreparadas++;
						jugable = false;
						StartCoroutine(RealizarSecuencia());
					}
				}
            }
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		// Verificar si se ha detectado alguna entrada (tecla, botón o toque) y la rotación es la deseada
        if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable &&
            rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f &&
            rotacionPlayer.y >= 20.77f && rotacionPlayer.y <= 33.9f)
        {
            // Reducir el contador si es mayor que 0
            if (ingredienteCebolla > 0)
            {
                ingredienteCebolla--; // Reducir el contador en 1
				ArregloDelJugador[indiceJugador]=3;
				if (ArregloDelJugador[indiceJugador]!= secuenciaAleatoria[indiceJugador])
				{
					Mal.SetActive(true);
					Bebop.Play();
					jugable = false;
					teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
					 
					StartCoroutine(RealizarSecuencia());
				}
				else
				{
					indiceHamburguesa++;
					if(indiceHamburguesa==1)
					{
						Cebolla1.SetActive(true);
						TapaderaPan1.SetActive(false);
						TapaderaPan2.SetActive(true);
					}
					if(indiceHamburguesa==2)
					{
						Cebolla2.SetActive(true);
						TapaderaPan2.SetActive(false);
						TapaderaPan3.SetActive(true);
					}
					if(indiceHamburguesa==3)
					{
						Cebolla3.SetActive(true);
						TapaderaPan3.SetActive(false);
						TapaderaPan4.SetActive(true);
					}
					if(indiceHamburguesa==4)
					{
						Cebolla4.SetActive(true);
						TapaderaPan4.SetActive(false);
						TapaderaPan5.SetActive(true);
					}
					if(indiceHamburguesa==5)
					{
						Cebolla5.SetActive(true);
						TapaderaPan5.SetActive(false);
						TapaderaPan6.SetActive(true);
					}
					if(indiceHamburguesa==6)
					{
						Cebolla6.SetActive(true);
						TapaderaPan6.SetActive(false);
						TapaderaPan7.SetActive(true);
					}
					if(indiceHamburguesa==7)
					{
						Cebolla7.SetActive(true);
						TapaderaPan7.SetActive(false);
						TapaderaPan8.SetActive(true);
					}
					if(indiceHamburguesa==8)
					{
						Cebolla8.SetActive(true);
						TapaderaPan8.SetActive(false);
						TapaderaPan9.SetActive(true);
					}
					indiceJugador++;
					if(indiceJugador<longitudSecuencia)
					{
						Correct.Play();
					}
					if(indiceJugador==longitudSecuencia)
					{
						BienHecho.SetActive(true);
						YEEEI.Play();
						HamburguesasPreparadas++;
						jugable = false;
						teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
						 
						StartCoroutine(RealizarSecuencia());
					}
				}
            }

            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		// Verificar si se ha detectado alguna entrada (tecla, botón o toque) y la rotación es la deseada
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 39.9f && rotacionPlayer.y <= 51.31f) // Detecta cualquier tecla presionada y que no haya sido presionada en este frame
        {
            // Reducir el contador si es mayor que 0
            if (ingredienteJitomate > 0)
            {
                ingredienteJitomate--; // Reducir el contador en 1
				ArregloDelJugador[indiceJugador]=4;
				if (ArregloDelJugador[indiceJugador]!= secuenciaAleatoria[indiceJugador])
				{
					Mal.SetActive(true);
					Bebop.Play();
					jugable = false;
					teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
					 
					StartCoroutine(RealizarSecuencia());
				}
				else
				{
					indiceHamburguesa++;
					if(indiceHamburguesa==1)
					{
						Jitomate1.SetActive(true);
						TapaderaPan1.SetActive(false);
						TapaderaPan2.SetActive(true);
					}
					if(indiceHamburguesa==2)
					{
						Jitomate2.SetActive(true);
						TapaderaPan2.SetActive(false);
						TapaderaPan3.SetActive(true);
					}
					if(indiceHamburguesa==3)
					{
						Jitomate3.SetActive(true);
						TapaderaPan3.SetActive(false);
						TapaderaPan4.SetActive(true);
					}
					if(indiceHamburguesa==4)
					{
						Jitomate4.SetActive(true);
						TapaderaPan4.SetActive(false);
						TapaderaPan5.SetActive(true);
					}
					if(indiceHamburguesa==5)
					{
						Jitomate5.SetActive(true);
						TapaderaPan5.SetActive(false);
						TapaderaPan6.SetActive(true);
					}
					if(indiceHamburguesa==6)
					{
						Jitomate6.SetActive(true);
						TapaderaPan6.SetActive(false);
						TapaderaPan7.SetActive(true);
					}
					if(indiceHamburguesa==7)
					{
						Jitomate7.SetActive(true);
						TapaderaPan7.SetActive(false);
						TapaderaPan8.SetActive(true);
					}
					if(indiceHamburguesa==8)
					{
						Jitomate8.SetActive(true);
						TapaderaPan8.SetActive(false);
						TapaderaPan9.SetActive(true);
					}
					indiceJugador++;
					if(indiceJugador<longitudSecuencia)
					{
						Correct.Play();
					}
					if(indiceJugador==longitudSecuencia)
					{
						BienHecho.SetActive(true);
						HamburguesasPreparadas++;
						YEEEI.Play();
						jugable = false;
						teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
						 
						StartCoroutine(RealizarSecuencia());
					}
				}
            }

            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		// Verificar si se ha detectado alguna entrada (tecla, botón o toque) y la rotación es la deseada
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && rotacionPlayer.x >= 14.7f && rotacionPlayer.x <= 25.7f && rotacionPlayer.y >= 290.18f && rotacionPlayer.y <= 305.0f) // Detecta cualquier tecla presionada y que no haya sido presionada en este frame
        {
            // Reducir el contador si es mayor que 0
            if (ingredienteLechuga > 0)
            {
                ingredienteLechuga--; // Reducir el contador en 1
				ArregloDelJugador[indiceJugador]=0;
				if (ArregloDelJugador[indiceJugador]!= secuenciaAleatoria[indiceJugador])
				{
					Mal.SetActive(true);
					Bebop.Play();
					jugable = false;
					teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
					 
					StartCoroutine(RealizarSecuencia());
				}
				else
				{
					indiceHamburguesa++;
					if(indiceHamburguesa==1)
					{
						Lechuga1.SetActive(true);
						TapaderaPan1.SetActive(false);
						TapaderaPan2.SetActive(true);
					}
					if(indiceHamburguesa==2)
					{
						Lechuga2.SetActive(true);
						TapaderaPan2.SetActive(false);
						TapaderaPan3.SetActive(true);
					}
					if(indiceHamburguesa==3)
					{
						Lechuga3.SetActive(true);
						TapaderaPan3.SetActive(false);
						TapaderaPan4.SetActive(true);
					}
					if(indiceHamburguesa==4)
					{
						Lechuga4.SetActive(true);
						TapaderaPan4.SetActive(false);
						TapaderaPan5.SetActive(true);
					}
					if(indiceHamburguesa==5)
					{
						Lechuga5.SetActive(true);
						TapaderaPan5.SetActive(false);
						TapaderaPan6.SetActive(true);
					}
					if(indiceHamburguesa==6)
					{
						Lechuga6.SetActive(true);
						TapaderaPan6.SetActive(false);
						TapaderaPan7.SetActive(true);
					}
					if(indiceHamburguesa==7)
					{
						Lechuga7.SetActive(true);
						TapaderaPan7.SetActive(false);
						TapaderaPan8.SetActive(true);
					}
					if(indiceHamburguesa==8)
					{
						Lechuga8.SetActive(true);
						TapaderaPan8.SetActive(false);
						TapaderaPan9.SetActive(true);
					}
					indiceJugador++;
					if(indiceJugador<longitudSecuencia)
					{
						Correct.Play();
					}
					if(indiceJugador==longitudSecuencia)
					{
						BienHecho.SetActive(true);
						YEEEI.Play();
						HamburguesasPreparadas++;
						jugable = false;
						teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
						 
						StartCoroutine(RealizarSecuencia());
					}
				}
            }

            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		// Verificar si se ha detectado alguna entrada (tecla, botón o toque) y la rotación es la deseada
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 57.4f && rotacionPlayer.y <= 70.4f) // Detecta cualquier tecla presionada y que no haya sido presionada en este frame
        {
            // Reducir el contador si es mayor que 0
            if (ingredientePapa > 0)
            {
                ingredientePapa--; // Reducir el contador en 1
				ArregloDelJugador[indiceJugador]=5;
				if (ArregloDelJugador[indiceJugador]!= secuenciaAleatoria[indiceJugador])
				{
					Mal.SetActive(true);
					Bebop.Play();
					jugable = false;
					teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
					 
					StartCoroutine(RealizarSecuencia());
				}
				else
				{
					indicePapas++;
					if(indicePapas==1)
					{
						ComboPapas1.SetActive(true);
					}
					if(indicePapas==2)
					{
						ComboPapas2.SetActive(true);
					}
					if(indicePapas==3)
					{
						ComboPapas3.SetActive(true);
					}
					if(indicePapas==4)
					{
						ComboPapas4.SetActive(true);
					}
					if(indicePapas==5)
					{
						ComboPapas5.SetActive(true);
					}
					if(indicePapas==6)
					{
						ComboPapas6.SetActive(true);
					}
					if(indicePapas==7)
					{
						ComboPapas7.SetActive(true);
					}
					if(indicePapas==8)
					{
						ComboPapas8.SetActive(true);
					}
					indiceJugador++;
					if(indiceJugador<longitudSecuencia)
					{
						Correct.Play();
					}
					if(indiceJugador==longitudSecuencia)
					{
						BienHecho.SetActive(true);
						YEEEI.Play();
						HamburguesasPreparadas++;
						jugable = false;
						teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
						 
						StartCoroutine(RealizarSecuencia());
					}
				}
            }

            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 308.6f && rotacionPlayer.y <= 321.76f) // Detecta cualquier tecla presionada y que no haya sido presionada en este frame
        {
            // Reducir el contador si es mayor que 0
            if (ingredienteQueso > 0)
            {
                ingredienteQueso--; // Reducir el contador en 1
				ArregloDelJugador[indiceJugador]=1;
				if (ArregloDelJugador[indiceJugador]!= secuenciaAleatoria[indiceJugador])
				{
					Mal.SetActive(true);
					Bebop.Play();
					jugable = false;
					teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
					 
					StartCoroutine(RealizarSecuencia());
				}
				else
				{
					indiceHamburguesa++;
					if(indiceHamburguesa==1)
					{
						Queso1.SetActive(true);
						TapaderaPan1.SetActive(false);
						TapaderaPan2.SetActive(true);
					}
					if(indiceHamburguesa==2)
					{
						Queso2.SetActive(true);
						TapaderaPan2.SetActive(false);
						TapaderaPan3.SetActive(true);
					}
					if(indiceHamburguesa==3)
					{
						Queso3.SetActive(true);
						TapaderaPan3.SetActive(false);
						TapaderaPan4.SetActive(true);
					}
					if(indiceHamburguesa==4)
					{
						Queso4.SetActive(true);
						TapaderaPan4.SetActive(false);
						TapaderaPan5.SetActive(true);
					}
					if(indiceHamburguesa==5)
					{
						Queso5.SetActive(true);
						TapaderaPan5.SetActive(false);
						TapaderaPan6.SetActive(true);
					}
					if(indiceHamburguesa==6)
					{
						Queso6.SetActive(true);
						TapaderaPan6.SetActive(false);
						TapaderaPan7.SetActive(true);
					}
					if(indiceHamburguesa==7)
					{
						Queso7.SetActive(true);
						TapaderaPan7.SetActive(false);
						TapaderaPan8.SetActive(true);
					}
					if(indiceHamburguesa==8)
					{
						Queso8.SetActive(true);
						TapaderaPan8.SetActive(false);
						TapaderaPan9.SetActive(true);
					}
					indiceJugador++;
					if(indiceJugador<longitudSecuencia)
					{
						Correct.Play();
					}
					if(indiceJugador==longitudSecuencia)
					{
						BienHecho.SetActive(true);
						YEEEI.Play();
						HamburguesasPreparadas++;
						jugable = false;
						teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
						 
						StartCoroutine(RealizarSecuencia());
					}
				}
            }

            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		// Verificar si se ha detectado alguna entrada (tecla, botón o toque) y la rotación es la deseada
        if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable &&
            rotacionPlayer.x >= 3.0f && rotacionPlayer.x <= 20.2f &&
            rotacionPlayer.y >= 75.94f && rotacionPlayer.y <= 87.2f)
        {
            // Reducir el contador si es mayor que 0
            if (ingredienteRefrescos > 0)
            {
                ingredienteRefrescos--; // Reducir el contador en 1
				ArregloDelJugador[indiceJugador]=6;
				if (ArregloDelJugador[indiceJugador]!= secuenciaAleatoria[indiceJugador])
				{
					Mal.SetActive(true);
					Bebop.Play();
					jugable = false;
					teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
					 
					StartCoroutine(RealizarSecuencia());
				}
				else
				{
					objetoRefresco.SetActive(true);//Activar Vista de refresco
					indiceJugador++;
					if(indiceJugador<longitudSecuencia)
					{
						Correct.Play();
					}
					if(indiceJugador==longitudSecuencia)
					{
						BienHecho.SetActive(true);
						YEEEI.Play();
						HamburguesasPreparadas++;
						jugable = false;
						teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
						StartCoroutine(RealizarSecuencia());
					}
				}
            }
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		tiempoTranscurrido += Time.deltaTime;
		if (tiempoTranscurrido >= 300)
		{
			// Cambiar la variable tiempoJugable a false
			tiempoJugable = false;
		}
		if (tiempoTranscurrido >= tiempoInicial)
		{
			
	
			// Guardar el valor de HamburguesasPreparadas antes de cambiar de escena
			PlayerPrefs.SetInt("HamburguesasPreparadas", HamburguesasPreparadas);
			PlayerPrefs.Save();
	
			// Cambiar a la nueva escena
			SceneManager.LoadScene("Resultados");
		}
		ActualizarIndicadorPasos();
		// Refrigerador
        if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 7.58f && rotacionPlayer.x <= 17.93f && rotacionPlayer.y >= 213.75f && rotacionPlayer.y <= 220.5f)
        {
            // Reinicia el contador a 10
			ingredienteCarnes = 10;
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 338.1f && rotacionPlayer.x <= 348.3f && rotacionPlayer.y >= 200.0f && rotacionPlayer.y <= 207.5f)
        {
            // Reinicia el contador a 10
			ingredienteCebolla = 10;
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && ((rotacionPlayer.x >= 0.0f && rotacionPlayer.x <= 1.0f) || (rotacionPlayer.x >= 351.5f && rotacionPlayer.x < 360.0f)) && rotacionPlayer.y >= 199.3f && rotacionPlayer.y <= 207.5f)
        {
            // Reinicia el contador a 10
			ingredienteJitomate = 10;
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && ((rotacionPlayer.x >= 0.0f && rotacionPlayer.x <= 1.0f) || (rotacionPlayer.x >= 351.5f && rotacionPlayer.x < 360.0f)) && rotacionPlayer.y >= 211.63f && rotacionPlayer.y <= 219.3f)
        {
            // Reinicia el contador a 10
			ingredienteQueso = 10;
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 338.1f && rotacionPlayer.x <= 348.3f && rotacionPlayer.y >= 213.0f && rotacionPlayer.y <= 220.7f)
        {
            // Reinicia el contador a 10
			ingredienteLechuga = 10;
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 7.7f && rotacionPlayer.x <= 18.0f && rotacionPlayer.y >= 199.4f && rotacionPlayer.y <= 206.9f)
        {
            // Reinicia el contador a 10
			ingredientePapa = 10;
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
		if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 22.0f && rotacionPlayer.x <= 27.0f && rotacionPlayer.y >= 201.46f && rotacionPlayer.y <= 217.1f)
        {
            // Reinicia el contador a 10
			ingredienteRefrescos = 10;
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
        // Iterar sobre cada objeto de Carnes desde el final del arreglo
        for (int i = 9; i >= 0; i--)
        {
            // Desactivar el objeto si su índice es mayor o igual al valor del contador
            objetosCarnes[i].SetActive(i < ingredienteCarnes);
        }
		// Iterar sobre cada objeto de Cebolla desde el final del arreglo
        for (int i = 9; i >= 0; i--)
        {
            // Desactivar el objeto si su índice es mayor o igual al valor del contador
            objetosCebolla[i].SetActive(i < ingredienteCebolla);
        }
		// Iterar sobre cada objeto de Jitomate desde el final del arreglo
        for (int i = 9; i >= 0; i--)
        {
            // Desactivar el objeto si su índice es mayor o igual al valor del contador
            objetosJitomate[i].SetActive(i < ingredienteJitomate);
        }
		// Iterar sobre cada objeto de Lechuga desde el final del arreglo
        for (int i = 9; i >= 0; i--)
        {
            // Desactivar el objeto si su índice es mayor o igual al valor del contador
            objetosLechuga[i].SetActive(i < ingredienteLechuga);
        }
		// Iterar sobre cada objeto de Papa desde el final del arreglo
        for (int i = 9; i >= 0; i--)
        {
            // Desactivar el objeto si su índice es mayor o igual al valor del contador
            objetosPapa[i].SetActive(i < ingredientePapa);
        }
		// Iterar sobre cada objeto de Queso desde el final del arreglo
        for (int i = 9; i >= 0; i--)
        {
            // Desactivar el objeto si su índice es mayor o igual al valor del contador
            objetosQueso[i].SetActive(i < ingredienteQueso);
        }
		// Iterar sobre cada objeto de Refrescos desde el final del arreglo
        for (int i = 9; i >= 0; i--)
        {
            // Desactivar el objeto si su índice es mayor o igual al valor del contador
            objetosRefrescos[i].SetActive(i < ingredienteRefrescos);
        }
		
		// Animacion de puerta del Refri
        if (tiempoJugable && Input.anyKeyDown && !teclaPresionada && jugable &&((rotacionPlayer.x >= 330.9f && rotacionPlayer.x <= 359.999f) || (rotacionPlayer.x >= 0.0f && rotacionPlayer.x <= 30.0f)) && rotacionPlayer.y >= 195.55f && rotacionPlayer.y <= 224.3f)
        {
            // Rotar la puerta del refrigerador desde 360 a 238 en el eje Y
            if (!puertaAbierta)
            {
                puertaAbierta = true;
            }
            teclaPresionada = true; // Marcar que se ha presionado una tecla en este frame
        }
        // Si la puerta está abierta y la cámara rota a más de 316.5 o menos de 110.2, volver a cerrar la puerta
        if (puertaAbierta && (rotacionPlayer.y > 320.5f || rotacionPlayer.y < 110.2f))
        {
            PuertaRefri.transform.rotation = Quaternion.Euler(0f, 359.999f, 0f);
            puertaAbierta = false;
        }
		// Si la puerta está abierta y la rotación de la puerta es mayor a 280 grados, seguir cerrando la puerta gradualmente
		if (puertaAbierta)
		{
			Quaternion targetRotation = Quaternion.Euler(0f, 220f, 0f); // Rotación deseada para cerrar la puerta
		
			// Interpolar suavemente entre la rotación actual y la rotación deseada
			PuertaRefri.transform.rotation = Quaternion.Lerp(PuertaRefri.transform.rotation, targetRotation, Time.deltaTime * velocidadCierre);
		}

        // Reiniciar la variable teclaPresionada al final de cada frame
        teclaPresionada = false;
		//LUZ VERDE
        if (tiempoJugable && jugable && rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 327.39f && rotacionPlayer.y <= 339.67f)
        {
            if (ingredienteCarnes > 0)
            {
                condicionCumplida = true;
            }
        }
        if (tiempoJugable && jugable && rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 20.77f && rotacionPlayer.y <= 33.9f)
        {
            if (ingredienteCebolla > 0)
            {
				condicionCumplida = true;
            }
        }
		if (tiempoJugable && jugable && rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 39.9f && rotacionPlayer.y <= 51.31f) // Detecta cualquier tecla presionada y que no haya sido presionada en este frame
        {
            if (ingredienteJitomate > 0)
            {
				condicionCumplida = true;
            }

        }
		if (tiempoJugable && jugable && rotacionPlayer.x >= 14.7f && rotacionPlayer.x <= 25.7f && rotacionPlayer.y >= 290.18f && rotacionPlayer.y <= 305.0f) // Detecta cualquier tecla presionada y que no haya sido presionada en este frame
        {
            if (ingredienteLechuga > 0)
            {
				condicionCumplida = true;
            }
        }
		if (tiempoJugable && jugable && rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 57.4f && rotacionPlayer.y <= 70.4f) // Detecta cualquier tecla presionada y que no haya sido presionada en este frame
        {
            if (ingredientePapa > 0)
            {
				condicionCumplida = true;
            }
        }
		if (tiempoJugable && jugable && rotacionPlayer.x >= 14.5f && rotacionPlayer.x <= 25.4f && rotacionPlayer.y >= 308.6f && rotacionPlayer.y <= 321.76f) // Detecta cualquier tecla presionada y que no haya sido presionada en este frame
        {
            if (ingredienteQueso > 0)
            {
				condicionCumplida = true;
            }
        }
        if (tiempoJugable && jugable && rotacionPlayer.x >= 3.0f && rotacionPlayer.x <= 20.2f && rotacionPlayer.y >= 75.94f && rotacionPlayer.y <= 87.2f)
        {
            if (ingredienteRefrescos > 0)
            {
				condicionCumplida = true;
            }
        }
        if (tiempoJugable && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 7.58f && rotacionPlayer.x <= 17.93f && rotacionPlayer.y >= 213.75f && rotacionPlayer.y <= 220.5f)
        {
            condicionCumplida = true;
        }
		if (tiempoJugable && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 338.1f && rotacionPlayer.x <= 348.3f && rotacionPlayer.y >= 200.0f && rotacionPlayer.y <= 207.5f)
        {
            condicionCumplida = true;
        }
		if (tiempoJugable && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && ((rotacionPlayer.x >= 0.0f && rotacionPlayer.x <= 1.0f) || (rotacionPlayer.x >= 351.5f && rotacionPlayer.x < 360.0f)) && rotacionPlayer.y >= 199.3f && rotacionPlayer.y <= 207.5f)
        {
            condicionCumplida = true;
        }
		if (tiempoJugable && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && ((rotacionPlayer.x >= 0.0f && rotacionPlayer.x <= 1.0f) || (rotacionPlayer.x >= 351.5f && rotacionPlayer.x < 360.0f)) && rotacionPlayer.y >= 211.63f && rotacionPlayer.y <= 219.3f)
        {
            condicionCumplida = true;
        }
		if (tiempoJugable && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 338.1f && rotacionPlayer.x <= 348.3f && rotacionPlayer.y >= 213.0f && rotacionPlayer.y <= 220.7f)
        {
            condicionCumplida = true;
        }
		if (tiempoJugable && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 7.7f && rotacionPlayer.x <= 18.0f && rotacionPlayer.y >= 199.4f && rotacionPlayer.y <= 206.9f)
        {
            condicionCumplida = true;
        }
		if (tiempoJugable && jugable && puertaAbierta && rotacionRefri.y <= 265.0f && rotacionPlayer.x >= 22.0f && rotacionPlayer.x <= 27.0f && rotacionPlayer.y >= 201.46f && rotacionPlayer.y <= 217.1f)
        {
            condicionCumplida = true;
        }
        if (tiempoJugable && !puertaAbierta  && jugable &&((rotacionPlayer.x >= 330.9f && rotacionPlayer.x <= 359.999f) || (rotacionPlayer.x >= 0.0f && rotacionPlayer.x <= 30.0f)) && rotacionPlayer.y >= 195.55f && rotacionPlayer.y <= 224.3f)
        {
            condicionCumplida = true;
        }
        objetoAControlar.SetActive(condicionCumplida);
    }
	void ActualizarIndicadorPasos()
    {
        textoPasos.text = $"Pedido: {indiceJugador}/{NumPasos}";
		HamburguesasHechas.text = $"{HamburguesasPreparadas}";
    }
}
