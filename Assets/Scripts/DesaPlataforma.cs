using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaPlataforma : MonoBehaviour
{
    int ApareceLa1;
    public GameObject plataforma2;
    // Start is called before the first frame update
    void Start()
    {
        ApareceLa1 = Random.Range(1, 3);

        if (ApareceLa1 == 1){
            plataforma2.GetComponent<BoxCollider>().enabled = false;
        } 
        else
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
