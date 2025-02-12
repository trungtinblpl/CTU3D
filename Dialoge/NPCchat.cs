using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading.Tasks;

public class NPCchat : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject toActive;
    [SerializeField] private Transform standingPoint;

    private async void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Transform avatar = other.transform;

            avatar.GetComponent<PlayerInput>().enabled = false;

            await Task.Delay(50);

            mainCamera.SetActive(false);
            toActive.SetActive(true);

            avatar.position = standingPoint.position;
            avatar.rotation = standingPoint.rotation;

        }
    }
}
