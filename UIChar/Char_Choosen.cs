using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Char_Choosen : MonoBehaviour
{
    public GameObject[] chars;
    public Button next;
    public Button pre;
    int index;

    void Start()
    {
        if (chars == null || chars.Length == 0)
        {
            // Debug.LogError("Mảng chars chưa được gán hoặc rỗng!");
            return;
        }

        index = PlayerPrefs.GetInt("charIndex", 0);

        if (index < 0 || index >= chars.Length)
        {
            index = 0;
        }

        for (int i = 0; i < chars.Length; i++)
        {
            chars[i].SetActive(false);
        }

        chars[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= 2)
        {
            next.interactable = false;
        }
        else
        {
            next.interactable = true;
        }

        if (index <= 0)
        {
            pre.interactable = false;
        }
        else
        {
            pre.interactable = true;
        }
    }

    public void Next()
    {
        if (index < chars.Length - 1) // Kiểm tra giới hạn trước khi tăng index
        {
            chars[index].SetActive(false);  // Tắt nhân vật hiện tại
            index++;                        // Tăng chỉ số
            chars[index].SetActive(true);   // Bật nhân vật tiếp theo
            PlayerPrefs.SetInt("charIndex", index); // Lưu chỉ số vào PlayerPrefs
            PlayerPrefs.Save();             // Lưu thay đổi
        }
    }

    public void Pre()
    {
        if (index > 0)  // Kiểm tra giới hạn trước khi giảm index
        {
            chars[index].SetActive(false);  // Tắt nhân vật hiện tại
            index--;                        // Giảm chỉ số
            chars[index].SetActive(true);   // Bật nhân vật trước đó
            PlayerPrefs.SetInt("charIndex", index); // Lưu chỉ số vào PlayerPrefs
            PlayerPrefs.Save();             // Lưu thay đổi
        }
    }


    // public void Choose()
    // {
    //     SceneManager.LoadSceneAsync("CTU");
    // }

    public void Choose()
    {
        // Kiểm tra index để xác định cảnh cần tải
        if (index == 0) // Nếu index = 0 (nhân vật nam)
        {
            PlayerPrefs.SetInt("SavedScene", 2);
            SceneManager.LoadSceneAsync("CTU"); // Chuyển đến cảnh CTU
        }
        else if (index == 1) // Nếu index = 1 (nhân vật nữ)
        {
            PlayerPrefs.SetInt("SavedScene", 3);
            SceneManager.LoadSceneAsync("CTU 1"); // Chuyển đến cảnh CTU1
        }
        PlayerPrefs.Save();
    }
}
