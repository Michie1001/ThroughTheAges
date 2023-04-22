using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;
using TMPro;

public class ToPortalScreen : MonoBehaviour
{
    public GameObject TimelineSelector;
    void Start()
    {
        TimelineSelector.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //TimelineSelector = GameObject.FindGameObjectWithTag("Timeline");
            TimelineSelector.SetActive(true);
        }
    }
    void OnTriggerExit()
    {
        TimelineSelector.SetActive(false);
    }
}
