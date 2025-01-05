using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrenght = 10;
    }



    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrenght = 2;
    }
}
