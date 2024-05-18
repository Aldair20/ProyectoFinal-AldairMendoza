using UnityEngine;

public class PositionRestrictor : MonoBehaviour
{
    // Variable para almacenar la posición inicial del objeto
    private Vector3 initialPosition;

    void Start()
    {
        // Almacenar la posición inicial del objeto al comienzo
        initialPosition = transform.position;
    }

    void Update()
    {
        // Mantener la posición del objeto en su posición inicial
        transform.position = initialPosition;
    }
}
