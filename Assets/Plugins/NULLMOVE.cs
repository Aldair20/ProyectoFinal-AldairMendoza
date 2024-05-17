using UnityEngine;

public class PositionRestrictor : MonoBehaviour
{
    // Límite de posición permitido
    private Vector3 positionLimit = new Vector3(0, 0, 0.00999999f);

    void Update()
    {
        // Limitar la posición del objeto a los límites establecidos
        Vector3 restrictedPosition = transform.position;
        restrictedPosition.x = Mathf.Clamp(transform.position.x, 0, positionLimit.x);
        restrictedPosition.y = Mathf.Clamp(transform.position.y, 0, positionLimit.y);
        restrictedPosition.z = Mathf.Clamp(transform.position.z, 0, positionLimit.z);

        // Asignar la posición restringida al objeto
        transform.position = restrictedPosition;
    }
}
