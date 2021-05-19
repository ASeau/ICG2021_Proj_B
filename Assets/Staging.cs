using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staging : MonoBehaviour
{
    public HookBehav hook;

    void OnTriggerEnter(Collider other)
    {
        
        MeshRenderer renderer = other.GetComponent<MeshRenderer>();
        if (renderer != null)
        {
            renderer.material.color = Color.green;
            Debug.Log("item placed");
        }
    }
}
