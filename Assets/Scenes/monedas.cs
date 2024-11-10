using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntuaje puntuaje;

    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            puntuaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);    
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
