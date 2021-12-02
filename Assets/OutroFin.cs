using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OutroFin : MonoBehaviour
{
    public string CargaNivel;
    public float segundosrestantes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundosrestantes -= Time.deltaTime;

        if (segundosrestantes <= 0)
        {
            SceneManager.LoadScene(CargaNivel);

        }
    }
}
