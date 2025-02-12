using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpanwer : MonoBehaviour
{

    public GameObject[] AIPrefabs;
    public int AiToSpawm;
    public int Timer;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        int count = 0;
        while (count < AiToSpawm)
        {
            int randomIndex = Random.Range(0, AIPrefabs.Length);

            GameObject obj = Instantiate(AIPrefabs[randomIndex]);

            Transform child = transform.GetChild(Random.Range(0, transform.childCount - 1));
            obj.GetComponent<WayPointNagative>().currentWaypoint = child.GetComponent<Waypoint>();

            obj.transform.position = child.position;

            yield return new WaitForSeconds(Timer);

            count++;
        }
    }
}
