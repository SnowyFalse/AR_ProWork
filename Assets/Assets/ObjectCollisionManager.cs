
using System;
using UnityEngine;

public class ObjectCollisionManager : MonoBehaviour
{

    public GameObject singleObject;

    public GameObject firePlusQR;
    //https://stackoverflow.com/questions/50409639/check-if-collision-between-the-model-and-two-different-objects-is-happening-at-t
    
    private void OnTriggerEnter(Collider other)
    {
        
        singleObject.SetActive(false);
        Debug.Log("COLLISION DETECTED");
        if (singleObject.gameObject.tag == "Level1")
        {
            firePlusQR.SetActive(true);
        }
        /*
        {
            case "Level2":
                switch (other.gameObject.tag)
                {
                    case "Level1":
                        Debug.Log("Level 1 + Level 2");
                        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
                        Instantiate(cube, transform.position, transform.rotation);
                        //other.gameObject.GetComponent<MeshRenderer>().enabled = false;
                        break;
                }
                break;
            
        }*/
    }

    private void OnTriggerExit(Collider other)
    {
        singleObject.gameObject.GetComponent<MeshRenderer>().enabled = true;
        firePlusQR.gameObject.GetComponent<MeshRenderer>().enabled = false;
        Debug.Log("COLLISION ENDED");
    }
    
}
