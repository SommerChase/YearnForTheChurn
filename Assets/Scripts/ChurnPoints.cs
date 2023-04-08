using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChurnPoints : MonoBehaviour
{
    [SerializeField] private int churnOrder = 1;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public int churnPoints = 0;
    public TMP_Text churnPointsText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        //Debug.Log(other.gameObject);

        if (other.name == "Bottom Box Collider")
        {
            if (churnOrder != 1)
            {
                churnPoints += 1;
                Debug.Log(churnPoints);
                churnPointsText.text = churnPoints.ToString();
            }
            
            churnOrder = 1;
            Debug.Log(other.name);
            Debug.Log(churnOrder);
            AudioSource.PlayClipAtPoint(audioClip1, transform.position);
        }

        if (other.name == "Top Box Collider")
        {
            if (churnOrder != 2)
            {
                churnPoints += 1;
                Debug.Log(churnPoints);
                churnPointsText.text = churnPoints.ToString();
            }
            churnOrder = 2;
            Debug.Log(other.name);
            Debug.Log(churnOrder);
            AudioSource.PlayClipAtPoint(audioClip2, transform.position);
        }
    }
    
}
