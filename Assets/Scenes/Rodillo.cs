using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocidad1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * velocidad1 * Time.deltaTime, Space.World);
    }
}
