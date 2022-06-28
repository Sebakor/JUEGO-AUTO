using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAuto : MonoBehaviour
{
    public float VelMovimiento;
    Rigidbody rb;
    bool salto = true;
    public float JumpForce;
    public float RotacionVel;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        JumpForce = 15;
        VelMovimiento = 0.2f;
        RotacionVel = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -2){
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position = new Vector3(2.62f,4.9f,-1.47f);
        }

        if (Input.GetKeyDown(KeyCode.Space)){

            if (salto){
                salto = false;
                rb.AddForce(Vector3.up * JumpForce,ForceMode.Impulse);
            }
        }

        if (Input.GetKey(KeyCode.D)){
            transform.Rotate(0,RotacionVel,0);
        }
       
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(VelMovimiento,0,0);
        }
        
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(-VelMovimiento,0,0);
        }

        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(0,-VelMovimiento,0);
        }
        
        
    }

    void OnCollisionEnter(Collision other) {

        if(other.gameObject.name == "Rampa" || other.gameObject.name == "Salto"){
            salto = true;
        }
    }
}
