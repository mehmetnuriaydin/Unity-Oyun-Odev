using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drive : MonoBehaviour
{
    
    public Button driveButton;
    public GameObject Player2;
    public GameObject Player;
    public GameObject CarUnlocked;
    public GameObject DriveUiButton;
    public GameObject ExitUiButton;
    public GameObject Stickman_Tpose;
    public GameObject Car;
    
    private bool inVehicle = false;
    GameObject guiObj;


void Start()
{
        driveButton = GetComponent<Button>();
        //driveButton.onClick.AddListener(TaskOnClick);
        Debug.Log("started");
        Player2.SetActive(false);

        
}



 void OnTriggerStay(Collider other)
{
        
        

        if (other.gameObject.tag == "CarUnlocked")
        {
            Debug.Log("Car triggered");
            DriveUiButton.SetActive(true);

        }


    }

    public void TaskOnClick()
    {
        Player.SetActive(false);
        CarUnlocked.SetActive(false);
        Player2.SetActive(true);
        ExitUiButton.SetActive(true);
        inVehicle = true;
        //CameraController.TargetTransform = CarCameraController;
    }

    public void Exit()
    {
        Player.SetActive(true);
        CarUnlocked.SetActive(true);
        Player2.SetActive(false);
        ExitUiButton.SetActive(false);
        DriveUiButton.SetActive(false);
        inVehicle = false;

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CarUnlocked")
        {
            Debug.Log("Car untriggered");
            DriveUiButton.SetActive(false);

        }
        


    }

void Update()
{
        /*
    if (inVehicle == true && Input.GetButton("Drive"))
    {
        Player.SetActive(true);
        Player2.SetActive(true);
        inVehicle = false;
    }
*/        
    
}
}
