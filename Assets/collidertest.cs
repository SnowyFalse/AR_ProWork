using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidertest : MonoBehaviour
{
    public GameObject sphere;
    public GameObject merge;
    public GameObject merge1;
    public GameObject merge2;
    void OnTriggerEnter(Collider other)
    {
        sphere.SetActive(false);
        if (gameObject.tag == "Level1")
        {
            if (other.gameObject.tag == "Level2")
            {
                merge.SetActive(true);
            } else if (other.gameObject.tag == "Level3")
            {
                merge1.SetActive(true);
            } else if (other.gameObject.tag == "Level4")
            {
                merge2.SetActive(true);
            }
        } else if (gameObject.tag == "Level2")
        {
            if (other.gameObject.tag == "Level3")
            {
                merge1.SetActive(true);
            } else if (other.gameObject.tag == "Level4")
            {
                merge2.SetActive(true);
            } 
        } else if (gameObject.tag == "Level3")
        {
            if (other.gameObject.tag == "Level4")
            {
                merge1.SetActive(true);
            } 
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        sphere.SetActive(true);
        merge.SetActive(false);
        merge1.SetActive(false);
        merge2.SetActive(false);
        
    }
}
