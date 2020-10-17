using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Luz1 : MonoBehaviour
{
    public int id_;
    public int contador_;

    // Start is called before the first frame update
    void Start()
    {
        contador_ = 0;
        id_ = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("name = " + gameObject.name + " id = " + id_ + " contador = " + contador_);


        contador_++;
    }
}
