using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterChurnPoints : MonoBehaviour
{
    
    [SerializeField] private int yearnPoints = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Trigger point system
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("I'm triggered bb");
        yearnPoints += 1;

    }
}
