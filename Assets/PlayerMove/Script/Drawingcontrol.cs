using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingControl : MonoBehaviour
{
    private Color _tempColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        _tempColor = other.GetComponent<Renderer>().material.color;
        other.GetComponent<Renderer>().material.color = new Color(_tempColor.r, _tempColor.g, _tempColor.b, 1.0f);
    }

}
