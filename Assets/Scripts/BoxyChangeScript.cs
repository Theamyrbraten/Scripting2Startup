using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxyChangeScript : MonoBehaviour
{
    private void Start()
    {
        
    }
    // Update is called once per frame
    void OnBecameVisible()
    {
        print ("dafuq");
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        GetComponent<MeshRenderer>().material.color = new Color(
            Random.value, Random.value, Random.value);
    }
}
