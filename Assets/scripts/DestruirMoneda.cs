using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DestruirMoneda : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
   void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "moneda")
        {
            Destroy(col.gameObject);
           
        }
    }
}
