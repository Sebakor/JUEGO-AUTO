using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoAuto : MonoBehaviour
{
    Rigidbody rb;
    public float VelMovimiento;
    public float JumpForce;
    public float RotacionVel;
    bool salto = true;
    bool seJuega = true;
    bool Gano = true;
    public GameObject canvasRes;
    public GameObject cuboConfeti;
    GameObject clon;
    public Text txtTiempo;
    public Text textoGanar;
    public Image panel;
    public AudioManager miAM;
    public AudioManager miAM2;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        JumpForce = 15;
        VelMovimiento = 0.1f;
        RotacionVel = 0.1f;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (seJuega){
            
            if (120 - Mathf.Floor(Time.timeSinceLevelLoad) == 0){
                Gano = false;
                StartCoroutine(ConfetiYCosas());
            }

            if (transform.position.y <= -2){
                Gano = false;
                StartCoroutine(ConfetiYCosas());
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
                miAM2.Frenos();
            }
            
            if (Input.GetKey(KeyCode.W)){
                transform.Translate(-VelMovimiento,0,0);
            }

            if (Input.GetKey(KeyCode.A)){
                transform.Rotate(0,-VelMovimiento,0);
            } 

            txtTiempo.text = (Mathf.Floor(Time.timeSinceLevelLoad)).ToString();
        }
        
    }

    void OnCollisionEnter(Collision other) {

        if(other.gameObject.name == "Rampa" || other.gameObject.name == "Salto"){
            salto = true;
            JumpForce = 15;
        }

        if(other.gameObject.name == "PlataformaSalto"){
            salto = true;
            JumpForce = 8;
        }
        
        if(other.gameObject.name == "Caja" || other.gameObject.name == "Cylinder(Clone)"){
            Gano = false;
            miAM.Choque();
            StartCoroutine(ConfetiYCosas());
        }

        if(other.gameObject.name == "Final"){

            Gano = true;
            StartCoroutine(ConfetiYCosas());

        }
    }

    IEnumerator ConfetiYCosas(){
        
        seJuega = false;

        if(Gano){ 
            panel.color = Color.green;
            textoGanar.text = "GANASTE!";
        } else {
            panel.color = Color.red;
            textoGanar.text = "PERDISTE...";
        }

        transform.position = new Vector3(4.5f,3.2f,-1.47f);
        transform.eulerAngles = new Vector3(0, 0, 0);
        
        yield return new WaitForSeconds(2);

        for (int i = 0; i < 25; i++)
        {
            clon = Instantiate(cuboConfeti);
            Destroy(clon, 2);
        }

        yield return new WaitForSeconds(1);

        canvasRes.SetActive(true);
    }
}
