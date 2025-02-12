using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class SaveGlow : MonoBehaviour
{
    Game_Manager game_Manager;

    void Start()
    {
        game_Manager = GameObject.FindObjectOfType<Game_Manager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            game_Manager.SavePlayer();
        }
    }
}
