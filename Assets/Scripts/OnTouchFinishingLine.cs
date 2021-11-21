using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTouchFinishingLine : MonoBehaviour
{
    public GameObject finishingLine;
    public GameObject winText;

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
        if (collision.gameObject.name == "Finishing Line")
        {
            winText.SetActive(true);
        }
    }
}
