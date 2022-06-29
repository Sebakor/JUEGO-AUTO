using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorCilindros : MonoBehaviour
{
    public GameObject cilindro;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generadorCilindros());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator generadorCilindros(){
        while (true)
        {
            Instantiate(cilindro);
            yield return new WaitForSeconds(2.5f);
        }
    }
}
