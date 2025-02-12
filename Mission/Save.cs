using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public Game_Manager game_Manager;
    public Mission mission;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (mission.Mission1 == false)
            {
                mission.Mission1 = true;
                game_Manager.SavePlayer();
            }
            else if (mission.Mission2 == false)  // Nếu Mission2 chưa hoàn thành
            {
                mission.Mission2 = true;  // Hoàn thành Mission2
            }
            else if (mission.Mission3 == false)  // Nếu Mission3 chưa hoàn thành
            {
                mission.Mission3 = true;  // Hoàn thành Mission3
            }
            else if (mission.Mission4 == false)  // Nếu Mission4 chưa hoàn thành
            {
                mission.Mission4 = true;  // Hoàn thành Mission4
            }
        }
    }
}
