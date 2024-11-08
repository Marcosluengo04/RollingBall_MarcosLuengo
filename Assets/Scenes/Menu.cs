using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{ public Button Play;
    // Start is called before the first frame update
    void Start()
    {
        Play.onClick.AddListener(empezar);
    }
    
    void empezar()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
