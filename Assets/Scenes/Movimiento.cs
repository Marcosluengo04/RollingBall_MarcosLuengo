using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Movimiento : MonoBehaviour
    

{
    [SerializeField] float fuerzasalto;
    Rigidbody rb;
    
    //[SerializeField] int velocidad = 2;
    //[SerializeField] Vector3 direccion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.drag = 1f;
        rb.mass = 2;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        { 
             rb.AddForce(new Vector3( 0, 1, 0 ) * fuerzasalto,ForceMode.Impulse);
        }
        //transform.Rotate(direccionRot * velRot * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, 1) * fuerzasalto, ForceMode.Impulse);
        }

        //transform.rotation()


    }
}
