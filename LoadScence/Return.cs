// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class Return : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public string CNTT;
//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player")) // Nhân vật phải có tag "Player"
//         {
//             // Chuyển sang Scene khác
//             string returnScene = PlayerPrefs.GetString("CTU", "");

//             if (!string.IsNullOrEmpty(returnScene))
//             {
//                 SceneManager.LoadScene(CTU); // Quay về Scene ban đầu
//             }
//             else
//             {
//                 Debug.LogError("No return scene set in PlayerPrefs!");
//             }
//         }
//     }
// }

// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class ReturnToPreviousScene : MonoBehaviour
// {
//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player")) // Kiểm tra nếu là nhân vật
//         {
//             // Lấy tên Scene ban đầu đã lưu
//             string previousScene = PlayerPrefs.GetString("PreviousScene", "");

//             if (!string.IsNullOrEmpty(previousScene))
//             {
//                 SceneManager.LoadScene(previousScene); // Quay về Scene ban đầu
//             }
//             else
//             {
//                 Debug.LogError("No previous scene found in PlayerPrefs!");
//             }
//         }
//     }
// }
