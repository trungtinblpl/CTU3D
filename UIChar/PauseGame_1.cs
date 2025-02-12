using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject SettingsMenu;

    private void Start()
    {
        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        PauseButton.SetActive(false); // Đặt thành true khi tạm dừng
        PauseMenu.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void OpenSettings()
    {
        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void CloseSettings()
    {
        SettingsMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void Quit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Exits play mode in Unity Editor
#else
        Application.Quit(); // Quits the game in build
#endif
    }
}
