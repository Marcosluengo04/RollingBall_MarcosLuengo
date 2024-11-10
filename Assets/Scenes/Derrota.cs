
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Derrota : MonoBehaviour
{
    public Button Play11;
    // Start is called before the first frame update
    void Start()
    {
        Play11.onClick.AddListener(empezar11);
    }

    void empezar11()
    {

        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    
}

