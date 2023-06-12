using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.tag)
        {
            case "Level1":
                Debug.Log("Level 1");
                break;
            
        }
    }
}
