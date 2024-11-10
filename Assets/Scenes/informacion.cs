using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class informacion : MonoBehaviour
{
    public Button informacion1;
    // Start is called before the first frame update
    void Start()
    {
        informacion1.onClick.AddListener(comenzar);

    }
    void comenzar()
    {

        SceneManager.LoadScene("info");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
