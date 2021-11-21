using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchPowerUp : MonoBehaviour
{
    public GameObject powerUp;

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
        if (collision.gameObject.name == "Power-Up")
        {

            powerUp.SetActive(false);

            for (int i = 0; i < GetComponent<OnTouchLine>().disPlatformArray.Length; i++)
            {
                GetComponent<OnTouchLine>().disPlatformArray[i].GetComponent<MeshRenderer>().enabled = true;
            }

            StartCoroutine("hidePlatforms");
        }
    }

    IEnumerator hidePlatforms()
    {
        yield return new WaitForSeconds(2.5f);

        for (int i = 0; i < GetComponent<OnTouchLine>().disPlatformArray.Length; i++)
        {
            GetComponent<OnTouchLine>().disPlatformArray[i].GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
