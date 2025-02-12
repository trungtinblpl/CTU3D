using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    // public int index;
    // public GameObject[] chars;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     index = PlayerPrefs.GetInt("charIndex");
    //     Debug.Log("Selected character index: " + index);
    //     GameObject Char = Instantiate(chars[index], Vector3.zero, Quaternion.identity);
    // }
    [Header("Missons")]
    public bool Mission1;
    public bool Mission2;
    public GameObject mission1Area;
    public Transform playerGameObject;

    [Header("Player")]
    public Mission mission;

    private void Update()
    {
        if (Mission1 == true || Mission2 == true)
        {
            mission1Area.SetActive(false);
        }
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        playerGameObject.position = position;

        mission.Mission1 = data.Mission1;
        mission.Mission2 = data.Mission2;
        mission.Mission3 = data.Mission3;
        mission.Mission4 = data.Mission4;
        mission.Mission5 = data.Mission5;
        mission.Mission6 = data.Mission6;
        mission.Mission7 = data.Mission7;
        mission.Mission8 = data.Mission8;
        mission.Mission9 = data.Mission9;
        mission.Mission10 = data.Mission10;
    }
}
