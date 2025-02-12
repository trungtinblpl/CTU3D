using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public float[] position;
    public bool Mission1, Mission2, Mission3, Mission4, Mission5,
    Mission6, Mission7, Mission8, Mission9, Mission10;
    // public bool[] missions;

    public PlayerData(Game_Manager game_Manager)
    {
        position = new float[3];
        position[0] = game_Manager.transform.position.x;
        position[1] = game_Manager.transform.position.y;
        position[2] = game_Manager.transform.position.z;

        Mission1 = game_Manager.mission.Mission1;
        Mission2 = game_Manager.mission.Mission2;
        Mission3 = game_Manager.mission.Mission3;
        Mission4 = game_Manager.mission.Mission4;
        Mission5 = game_Manager.mission.Mission5;
        Mission6 = game_Manager.mission.Mission6;
        Mission7 = game_Manager.mission.Mission7;
        Mission8 = game_Manager.mission.Mission8;
        Mission9 = game_Manager.mission.Mission9;
        Mission10 = game_Manager.mission.Mission10;

        // missions = new bool[game_Manager.missions.Length];
        // for (int i = 0; i < game_Manager.missions.Length; i++)
        // {
        //     missions[i] = game_Manager.missions[i];
        // }
    }
}
