using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchLine : MonoBehaviour
{
    public GameObject[] disPlatformArray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Starting Line")
        {
            for (int i = 0; i < disPlatformArray.Length; i++)
            {
                disPlatformArray[i].GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
