// using UnityEngine;

// public class RestorePlayerPosition : MonoBehaviour
// {
//     public GameObject player; // Tham chiếu đến nhân vật trong Scene

//     void Start()
//     {
//         // Kiểm tra xem có dữ liệu vị trí nhân vật được lưu không
//         if (PlayerPrefs.HasKey("PlayerPosX") && PlayerPrefs.HasKey("PlayerPosY") && PlayerPrefs.HasKey("PlayerPosZ"))
//         {
//             float x = PlayerPrefs.GetFloat("PlayerPosX");
//             float y = PlayerPrefs.GetFloat("PlayerPosY");
//             float z = PlayerPrefs.GetFloat("PlayerPosZ");

//             // Đặt lại vị trí của nhân vật
//             player.transform.position = new Vector3(x, y, z);
//         }
//         else
//         {
//             Debug.LogWarning("No saved position found for the player!");
//         }
//     }
// }

using UnityEngine;

public class RestorePlayerPosition : MonoBehaviour
{
    void Start()
    {
        // Kiểm tra nếu dữ liệu vị trí tồn tại
        if (PlayerPrefs.HasKey("PlayerPosX"))
        {
            Debug.Log("Loading saved position...");
            float x = PlayerPrefs.GetFloat("PlayerPosX");
            float y = PlayerPrefs.GetFloat("PlayerPosY");
            float z = PlayerPrefs.GetFloat("PlayerPosZ");
            Debug.Log($"Loaded position: {x}, {y}, {z}");

            // Gán vị trí đã lưu cho nhân vật
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                Debug.Log("Player found. Setting position...");
                player.transform.position = new Vector3(x, y, z);
            }
            else
            {
                Debug.LogError("Player not found!");
            }
        }
        else
        {
            Debug.LogWarning("No saved position found.");
        }
    }
}
