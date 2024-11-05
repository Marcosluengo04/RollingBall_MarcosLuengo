using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlataformaMovil : MonoBehaviour
{
    // Punto inicial y final de la plataforma
    public Transform puntoA;
    public Transform puntoB;

    // Velocidad de movimiento de la plataforma
    public float velocidad = 2f;

    // Dirección en la que se mueve la plataforma
    private Vector3 destinoActual;

    void Start()
    {
        // Comienza moviéndose hacia el punto B
        destinoActual = puntoB.position;
    }

    void Update()
    {
        // Mueve la plataforma hacia el destino actual
        transform.position = Vector3.MoveTowards(transform.position, destinoActual, velocidad * Time.deltaTime);

        // Si la plataforma ha llegado al destino, cambia al otro punto
        if (Vector3.Distance(transform.position, destinoActual) < 0.1f)
        {
            // Cambia el destino entre el punto A y el punto B
            destinoActual = destinoActual == puntoA.position ? puntoB.position : puntoA.position;
        }
    }

    private void OnDrawGizmos()
    {
        // Dibuja líneas en la vista de escena para visualizar los puntos de la plataforma
        if (puntoA != null && puntoB != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(puntoA.position, puntoB.position);
        }
    }
}
