using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
    public bool Mission1 = false;
    public bool Mission2 = false;
    public bool Mission3 = false;
    public bool Mission4 = false;
    public bool Mission5 = false;
    public bool Mission6 = false;
    public bool Mission7 = false;
    public bool Mission8 = false;
    public bool Mission9 = false;
    public bool Mission10 = false;

    public Text missionText;

    private void Update()
    {
        UpdateMissionText();
    }

    // Cập nhật nhiệm vụ trên giao diện
    private void UpdateMissionText()
    {
        if (!Mission1)
        {
            missionText.text = "Let's go to the Can Tho University Administration Building. And talk to the Guide.";
        }
        else if (Mission1 && !Mission2)
        {
            missionText.text = "Let's find out the Advanced Technology Building. And talk to the Guide.";
        }
        else if (Mission1 && Mission2 && !Mission3)
        {
            missionText.text = "Now, find the Turtle Hall and talk to the Guide.";
        }
        else if (Mission1 && Mission2 && Mission3 && !Mission4)
        {
            missionText.text = "Proceed to the C1 study house.";
        }
        else if (Mission1 && Mission2 && Mission3 && Mission4 && !Mission5)
        {
            missionText.text = "Proceed to the School of Information and Communication Technology.";
        }
        else if (Mission1 && Mission2 && Mission3 && Mission4 && Mission5 && !Mission6)
        {
            missionText.text = "Go to B1 stydy house.";
        }
        else if (Mission1 && Mission2 && Mission3 && Mission4 && Mission5 && Mission6 && !Mission7)
        {
            missionText.text = "Visit the Faculty of Physical Education.";
        }
        else if (Mission1 && Mission2 && Mission3 && Mission4 && Mission5 && Mission6 && Mission7 && !Mission8)
        {
            missionText.text = "Now, find the Faculty of Natural Sciences.";
        }
        else if (Mission1 && Mission2 && Mission3 && Mission4 && Mission5 && Mission6 && Mission7 && Mission8 && !Mission9)
        {
            missionText.text = "Check out the School of Economics.";
        }
        else if (Mission1 && Mission2 && Mission3 && Mission4 && Mission5 && Mission6 && Mission7 && Mission8 && Mission9 && !Mission10)
        {
            missionText.text = "Explore the Learning Resource Center (LRC).";
        }
        else if (Mission1 && Mission2 && Mission3 && Mission4 && Mission5 && Mission6 && Mission7 && Mission8 && Mission9 && Mission10)
        {
            missionText.text = "All missions completed successfully.";
        }
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Mission : MonoBehaviour
// {
//     public List<string> missions = new List<string>
//     {
//         "Let's go to the Can Tho University Administration Building. And talk to the Guide.",
//         "Let's find out the Advanced Technology Building. And talk to the Guide.",
//         "Now, find the Turtle Hall and talk to the Guide.",
//         "Proceed to the C1 study house.",
//         "Proceed to the School of Information and Communication Technology.",
//         "Go to B1 study house.",
//         "Visit the Faculty of Physical Education.",
//         "Now, find the Faculty of Natural Sciences.",
//         "Check out the School of Economics.",
//         "Explore the Learning Resource Center (LRC)."
//     };

//     public List<bool> missionCompleted = new List<bool>();

//     public int currentMissionIndex = 0;
//     public Text missionText;

//     private void Start()
//     {
//         // Khởi tạo tất cả các nhiệm vụ là chưa hoàn thành
//         for (int i = 0; i < missions.Count; i++)
//         {
//             missionCompleted.Add(false); // Mỗi nhiệm vụ bắt đầu với trạng thái chưa hoàn thành
//         }
//     }

//     private void Update()
//     {
//         UpdateMissionText();
//     }

//     // Update mission text on the UI
//     private void UpdateMissionText()
//     {
//         // if (currentMissionIndex < missions.Count)
//         // {
//         //     missionText.text = missions[currentMissionIndex];
//         // }
//         // else
//         // {
//         //     missionText.text = "All missions completed successfully.";
//         // }

//         if (currentMissionIndex < missions.Count)
//         {
//             // Nếu nhiệm vụ chưa hoàn thành, hiển thị nó
//             if (!missionCompleted[currentMissionIndex])
//             {
//                 missionText.text = missions[currentMissionIndex];
//             }
//             else
//             {
//                 // Nếu nhiệm vụ đã hoàn thành, chuyển sang nhiệm vụ tiếp theo
//                 missionText.text = "Mission " + (currentMissionIndex + 1) + " completed!";
//             }
//         }
//         else
//         {
//             missionText.text = "All missions completed successfully.";
//         }
//     }

//     // Phương thức để đánh dấu nhiệm vụ là hoàn thành
//     public void CompleteMission()
//     {
//         if (currentMissionIndex < missions.Count && !missionCompleted[currentMissionIndex])
//         {
//             missionCompleted[currentMissionIndex] = true; // Đánh dấu nhiệm vụ hiện tại là hoàn thành
//             currentMissionIndex++; // Chuyển sang nhiệm vụ tiếp theo
//         }
//     }
// }