using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuaje : MonoBehaviour
{
    // Start is called before the first frame update
    float puntos;
    TextMeshProUGUI textMesh;
    void Start()
    {
        textMesh =GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        textMesh.text = puntos.ToString("0");
    }
    public void SumarPuntos(float puntosEntrada)
    { 
        puntos += puntosEntrada;
    }


}
