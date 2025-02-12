using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class CarInteraction : MonoBehaviour
{
    ThirdPersonController thirdPersonController;
    public GameObject player;
    // public GameObject car1, car2, car3;
    public List<GameObject> cars = new List<GameObject>();
    Transform exitPosition;
    public GameObject currentCar;
    public GameObject playerCamera;
    public bool playerInCar;
    public int carSeatRange = 3;
    public KeyCode carInteractKey = KeyCode.F;

    void start()
    {
        thirdPersonController = FindObjectOfType<ThirdPersonController>();
    }

    void Update()
    {
        if (playerInCar == true)
        {
            playerCamera.transform.position = exitPosition.transform.position;
            player.transform.position = exitPosition.transform.position;
        }

        if (Input.GetKeyDown(carInteractKey))
        {
            if (currentCar == null)
            {
                // TryEnterCar(car1);
                // TryEnterCar(car2);
                foreach (GameObject car in cars)
                {
                    TryEnterCar(car);
                    if (currentCar != null) break; // Thoát vòng lặp nếu đã vào xe
                }
            }
            else
            {
                ExitCar();
            }
        }
    }

    void TryEnterCar(GameObject car)
    {
        if (car != null && Vector3.Distance(player.transform.position,
        car.transform.position) < carSeatRange)
        {
            currentCar = car;
            exitPosition = currentCar.transform.Find("CarExitPoint");
            car.GetComponent<PrometeoCarController>().enabled = true;
            car.transform.Find("Camera").gameObject.SetActive(true);
            player.SetActive(false);
            playerCamera.gameObject.SetActive(false);
            playerInCar = true;
        }
    }

    void ExitCar()
    {
        currentCar.GetComponent<PrometeoCarController>().enabled = false;
        currentCar.transform.Find("Camera").gameObject.SetActive(false);

        exitPosition = currentCar.transform.Find("CarExitPoint");
        if (exitPosition != null)
        {
            player.transform.position = exitPosition.position;
        }
        else
        {
            Debug.LogError("carexit not found in the car!");
            player.transform.position = currentCar.transform.position;
        }

        player.SetActive(true);
        playerCamera.gameObject.SetActive(true);
        currentCar = null;
        playerInCar = false;
    }
}
