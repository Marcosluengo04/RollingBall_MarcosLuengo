using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuborotacion : MonoBehaviour
{
    public AudioClip gemaSound;
    public float volume = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            if (gemaSound != null)
            {
                AudioSource.PlayClipAtPoint(gemaSound, transform.position, volume);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3(0, 45, 0) *Time.deltaTime,Space.World);

        
    }
}
