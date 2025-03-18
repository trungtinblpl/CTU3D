using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame_2 : MonoBehaviour
{

    [Header("New Game")]
    [SerializeField] private GameObject gameNewScreen;

    [Header("Quit Confirmation Popup")]
    [SerializeField] private GameObject quitConfirmationPopup; // Popup UI for Yes/No

    [Header("Settings Panel")]
    [SerializeField] private GameObject settingsPanel;

    #region Quit Functions
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Exits play mode in Unity Editor
#else
        Application.Quit(); // Quits the game in build
#endif
    }

    public void CancelQuit()
    {
        quitConfirmationPopup.SetActive(false); // Close the Yes/No popup
    }
    #endregion


    #region Settings Functions
    // Hiển thị Settings Panel
    public void ShowSettings()
    {
        settingsPanel.SetActive(true);
    }


    // Tắt Settings Panel
    public void CancelSettings()
    {
        settingsPanel.SetActive(false);
    }
    #endregion
}
