using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
    

{
    [SerializeField] int velocidad = 2;
    [SerializeField] Vector3 direccion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(direccionRot * velRot * Time.deltaTime);
        
        transform.Translate( new Vector3(0 ,0, -1) * velocidad * Time.deltaTime );
        //transform.rotation()
        
        
    }
}
