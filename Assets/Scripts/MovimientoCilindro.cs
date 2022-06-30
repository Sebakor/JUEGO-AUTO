using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCilindro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -786){
            Destroy(gameObject, 0);
        } else {
            transform.Translate(0,0,0.25f);
        }
        
    }
}
