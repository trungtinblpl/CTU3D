using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;
// using UnityEngine.InputSystem;

public class Mission1 : MonoBehaviour
{
    Game_Manager gameManager;
    public Animator charAnimator;
    public GameObject playerChar;
    public Text uiText;
    public string[] textArray;
    private float timer = 0f;
    private int currentIndex = 0;
    bool isCollided = false;
    public GameObject mainCamera;
    public GameObject missionCamera;
    public GameObject missionLight;
    StarterAssetsInputs starterAssetsInputs;

    void Start()
    {
        gameManager = FindObjectOfType<Game_Manager>();
        starterAssetsInputs = FindObjectOfType<StarterAssetsInputs>();
        if (textArray.Length > 0)
        {
            uiText.text = textArray[0];
        }
    }

    void Update()
    {
        if (!isCollided)
        {
            uiText.gameObject.SetActive(false);
        }
        else
        {
            uiText.gameObject.SetActive(true);
        }

        if (isCollided)
        {
            if (playerChar != null)
            {
                ThirdPersonController thirdPersonController = playerChar.GetComponent<ThirdPersonController>();
                if (thirdPersonController != null)
                {
                    thirdPersonController.MoveSpeed = 0;
                    thirdPersonController.SprintSpeed = 0;
                }
            }

            mainCamera.SetActive(false);
            missionCamera.SetActive(true);

            charAnimator.SetBool("Talk", true);

            timer += Time.deltaTime;

            if (timer >= 5f)
            {
                timer = 0f;
                currentIndex = (currentIndex + 1) % textArray.Length;
                uiText.text = textArray[currentIndex];
            }

            if (Input.GetKeyDown(KeyCode.E) && isCollided == true)
            {
                isCollided = false;

                charAnimator.Play("Idle");
                uiText.text = "";

                Destroy(gameObject);
                Destroy(charAnimator.gameObject);

                if (playerChar != null)
                {
                    ThirdPersonController thirdPersonController = playerChar.GetComponent<ThirdPersonController>();
                    if (thirdPersonController != null)
                    {
                        thirdPersonController.MoveSpeed = 10.0f;
                        thirdPersonController.SprintSpeed = 5.335f;
                    }
                }
            }

            mainCamera.SetActive(true);
            missionCamera.SetActive(false);

            if (gameManager.Mission1 == false && gameManager.Mission2 == false)
            {
                gameManager.Mission1 = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            missionLight.SetActive(false);
            isCollided = true;
        }
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using StarterAssets;

// public class Mission1 : MonoBehaviour
// {
//     Mission mission;
//     public Animator charAnimator;
//     public GameObject playerChar;
//     public Text uiText;
//     public string[] textArray;
//     private float timer = 0f;
//     private int currentIndex = 0;
//     bool isCollided = false;
//     public GameObject mainCamera;
//     public GameObject missionCamera;
//     public GameObject missionLight;
//     StarterAssetsInputs starterAssetsInputs;

//     void Start()
//     {
//         mission = FindObjectOfType<Mission>();
//         starterAssetsInputs = FindObjectOfType<StarterAssetsInputs>();
//         if (textArray.Length > 0)
//         {
//             uiText.text = textArray[0];
//         }
//     }

//     void Update()
//     {
//         if (!isCollided)
//         {
//             uiText.gameObject.SetActive(false);
//         }
//         else
//         {
//             uiText.gameObject.SetActive(true);
//         }

//         if (isCollided)
//         {
//             if (playerChar != null)
//             {
//                 ThirdPersonController thirdPersonController = playerChar.GetComponent<ThirdPersonController>();
//                 if (thirdPersonController != null)
//                 {
//                     thirdPersonController.MoveSpeed = 0;
//                     thirdPersonController.SprintSpeed = 0;
//                 }
//             }

//             mainCamera.SetActive(false);
//             missionCamera.SetActive(true);

//             charAnimator.SetBool("Talk", true);

//             timer += Time.deltaTime;

//             if (timer >= 5f)
//             {
//                 timer = 0f;
//                 currentIndex = (currentIndex + 1) % textArray.Length;
//                 uiText.text = textArray[currentIndex];
//             }

//             if (Input.GetKeyDown(KeyCode.E) && isCollided == true)
//             {
//                 isCollided = false;

//                 charAnimator.Play("Idle");
//                 uiText.text = "";

//                 Destroy(gameObject);
//                 Destroy(charAnimator.gameObject);

//                 if (playerChar != null)
//                 {
//                     ThirdPersonController thirdPersonController = playerChar.GetComponent<ThirdPersonController>();
//                     if (thirdPersonController != null)
//                     {
//                         thirdPersonController.MoveSpeed = 10.0f;
//                         thirdPersonController.SprintSpeed = 5.335f;
//                     }
//                 }

//                 // Move to the next mission
//                 if (mission.currentMissionIndex < mission.missions.Count)
//                 {
//                     mission.currentMissionIndex++;
//                 }
//             }

//             mainCamera.SetActive(true);
//             missionCamera.SetActive(false);
//         }
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             missionLight.SetActive(false);
//             isCollided = true;
//         }
//     }
// }
