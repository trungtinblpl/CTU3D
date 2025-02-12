using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [Header("New Game")]
    [SerializeField] private GameObject gameNewScreen;

    [Header("Quit Confirmation Popup")]
    [SerializeField] private GameObject quitConfirmationPopup; // Popup UI for Yes/No

    [Header("Settings Panel")]
    [SerializeField] private GameObject settingsPanel;

    public void NewGameScreen()
    {
        SceneManager.LoadScene(1);
    }

    #region Quit Functions
    // This function will be called when the player wants to quit
    public void ShowQuitConfirmation()
    {
        quitConfirmationPopup.SetActive(true); // Show the Yes/No popup
    }

    // Called when the player presses Yes in the confirmation popup
    public void ConfirmQuit()
    {
        Application.Quit(); // Quits the game (only works in build)

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Exits play mode
#endif
    }

    // Called when the player presses No in the confirmation popup
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

