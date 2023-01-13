using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMetals : MonoBehaviour
{
    public Button getMetalsButton;
    public GameObject GetMetalsUiButton;
    public GameObject StashedMetalSpawnArea;

    void Start()
    {
        getMetalsButton = GetComponent<Button>();
    }

    void OnTriggerStay(Collider other)
    {



        if (other.gameObject.tag == "GetMetal")
        {
            GetMetalsUiButton.SetActive(true);

        }


    }

    public void WorkOnClick()
    {

        StashedMetalSpawnArea.SetActive(true);
        
    }

    

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GetMetal")
        {
            GetMetalsUiButton.SetActive(false);

        }
        


    }


    void Update()
    {
        
    }
}
