using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RETURN : MonoBehaviour
{
    public Button informacion2;
    // Start is called before the first frame update
    void Start()
    {
        informacion2.onClick.AddListener(si);

    }
    void si()
    {

        SceneManager.LoadScene("MenuInicial");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
