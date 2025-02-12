using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string sceneName = "CNTT"; // Tên scene cần chuyển
    public GameObject button; // Tham chiếu đến Button
    private bool isNearButton = false; // Kiểm tra nếu người chơi gần button

    private void Update()
    {
        // Kiểm tra nếu người chơi nhấn phím F và đang ở gần Button
        if (isNearButton && Input.GetKeyDown(KeyCode.F))
        {
            SavePlayerPosition(); // Lưu vị trí nhân vật
            LoadScene(); // Chuyển scene
        }

    }

    // Hàm thực hiện chức năng chuyển scene
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    // Lưu vị trí của nhân vật vào PlayerPrefs
    private void SavePlayerPosition()
    {
        GameObject player = GameObject.FindWithTag("Player"); // Tìm nhân vật
        if (player != null)
        {
            Vector3 position = player.transform.position; // Lấy vị trí hiện tại
            PlayerPrefs.SetFloat("PlayerPosX", position.x);
            PlayerPrefs.SetFloat("PlayerPosY", position.y);
            PlayerPrefs.SetFloat("PlayerPosZ", position.z);
            PlayerPrefs.Save(); // Lưu dữ liệu
        }
    }

    // Khi người chơi vào vùng Trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearButton = true; // Đặt trạng thái "gần Button"
            button.SetActive(true); // Hiển thị Button
        }
    }

    // Khi người chơi rời khỏi vùng Trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearButton = false; // Đặt trạng thái "không gần Button"
            button.SetActive(false); // Ẩn Button
        }
    }
}
