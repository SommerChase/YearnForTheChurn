using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChurnPoints : MonoBehaviour
{
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

        if (other.name == "Bottom Box Collider" && churnPoints % 2 == 1)
        {
            AudioSource.PlayClipAtPoint(audioClip1, transform.position);
            churnPoints += 1;
            Debug.Log(churnPoints);
            churnPointsText.text = churnPoints.ToString();
        }

        if (other.name == "Top Box Collider" && churnPoints % 2 == 0)
        {
            AudioSource.PlayClipAtPoint(audioClip2, transform.position);
            churnPoints += 1;
            Debug.Log(churnPoints);
            churnPointsText.text = churnPoints.ToString();
        }
    }

}
