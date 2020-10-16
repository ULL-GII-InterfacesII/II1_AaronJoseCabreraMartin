using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainCamera : MonoBehaviour
{
    public int id_;
    public int contador_;
    // Start is called before the first frame update
    void Start()
    {
        contador_ = 0;
        id_ = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("id = " + id_ + " contador = " + contador_);

        contador_++;
    }
}
