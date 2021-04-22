using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan : MonoBehaviour

{


    // Start is called before the first frame update

  

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ini Update");

    }

    void Awake()
    {
        Debug.Log("Awake dipanggil");
    }

    void Start()
    {
        Debug.Log("ini start");
    }

    void FixedUpdate()
    {
        Debug.Log("Waktu untuk FixedUpdate :" + Time.deltaTime);
    }
}
