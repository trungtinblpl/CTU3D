using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SavePosion : MonoBehaviour
{

    public static SavePosion Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Giữ lại nhân vật khi chuyển scene
        }
        else
        {
            Destroy(gameObject); // Nếu đã tồn tại, hủy object mới để tránh trùng lặp
        }
    }

    void Start()
    {
        LoadPlayerPosition();
    }

    void OnApplicationQuit()
    {
        SavePlayerPosition();
    }

    // public void SavePlayerPosition()
    // {
    //     Vector3 playerPosition = transform.position;
    //     PlayerPrefs.SetFloat("PlayerX", playerPosition.x);
    //     PlayerPrefs.SetFloat("PlayerY", playerPosition.y);
    //     PlayerPrefs.SetFloat("PlayerZ", playerPosition.z);
    //     PlayerPrefs.Save();
    // }
    public void SavePlayerPosition()
    {
        Vector3 playerPosition = transform.position;
        string currentScene = SceneManager.GetActiveScene().name;

        PlayerPrefs.SetString("LastScene", currentScene); // Lưu tên scene hiện tại
        PlayerPrefs.SetFloat(currentScene + "_X", playerPosition.x);
        PlayerPrefs.SetFloat(currentScene + "_Y", playerPosition.y);
        PlayerPrefs.SetFloat(currentScene + "_Z", playerPosition.z);
        PlayerPrefs.Save();
    }


    public void LoadPlayerPosition()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (PlayerPrefs.HasKey(currentScene + "_X"))
        {
            float x = PlayerPrefs.GetFloat(currentScene + "_X");
            float y = PlayerPrefs.GetFloat(currentScene + "_Y");
            float z = PlayerPrefs.GetFloat(currentScene + "_Z");
            transform.position = new Vector3(x, y, z);
        }
    }

    // public void LoadPlayerPosition()
    // {
    //     if (PlayerPrefs.HasKey("PlayerX") && PlayerPrefs.HasKey("PlayerY") && PlayerPrefs.HasKey("PlayerZ"))
    //     {
    //         float x = PlayerPrefs.GetFloat("PlayerX");
    //         float y = PlayerPrefs.GetFloat("PlayerY");
    //         float z = PlayerPrefs.GetFloat("PlayerZ");
    //         transform.position = new Vector3(x, y, z);
    //     }
    // }
}
