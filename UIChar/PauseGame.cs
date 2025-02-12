// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PauseGame : MonoBehaviour
// {
//     [SerializeField] private GameObject PauseMenu;
//     // [SerializeField] private GameObject PauseButton;
//     private bool isPaused = false;
//     // [SerializeField] private GameObject pause;

//     // private void Awake()
//     // {
//     //     pause.SetActive(false);
//     // }
//     // Start is called before the first frame update
//     void Start()
//     {
//         PauseMenu.SetActive(false);
//     }


//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Escape))
//         {
//             if (isPaused)
//             {
//                 Resume();
//             }
//             else
//             {
//                 Pause();
//             }
//         }
//     }

//     public void Pause()
//     {
//         Time.timeScale = 0;
//         isPaused = true; // Đặt thành true khi tạm dừng
//         PauseMenu.SetActive(true);
//     }

//     public void Resume()
//     {
//         Time.timeScale = 1;
//         isPaused = false; // Đặt lại thành false khi tiếp tục
//         PauseMenu.SetActive(false);
//     }


//     public void Quit()
//     {
// #if UNITY_EDITOR
//         UnityEditor.EditorApplication.isPlaying = false; // Exits play mode in Unity Editor
// #else
//         Application.Quit(); // Quits the game in build
// #endif
//     }

//     // public void SoundVolume()
//     // {

//     // }
//     public void MusicVolume()
//     {
//         SoundManager.instance.changeMusicVolume(0.2f);
//     }
// }
