using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaFondoPlayer : MonoBehaviour
{
    public AudioManager miAM;
    // Start is called before the first frame update
    void Start()
    {
        miAM.MusicaCars();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
