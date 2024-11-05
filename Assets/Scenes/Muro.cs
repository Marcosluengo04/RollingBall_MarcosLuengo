using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject caja;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.name == "Ball") 
        {
            Instantiate(caja,transform.position ,Quaternion.identity);
            Destroy(this.gameObject);
        }
    
    
    
    }




}







        