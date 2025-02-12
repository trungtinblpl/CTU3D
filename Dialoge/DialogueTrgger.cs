using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrgger : MonoBehaviour
{
  public Dialogue dialogueScript;
  private bool playerDetected;
  public Animator charAnimator;
  // private Coroutine talkingCoroutine;

  //detect trigger with player
  private void OnTriggerEnter(Collider other)
  {
    //phat hien va cham va hien doan hoi thoai
    if (other.tag == "Player")
    {
      playerDetected = true;
      dialogueScript.ToggleIndicator(playerDetected);
    }
  }

  private void OnTriggerExit(Collider other)
  {
    //lost trigger(phat hien) by player => tat cai show noi dung
    if (other.tag == "Player")
    {
      playerDetected = false;
      dialogueScript.ToggleIndicator(playerDetected);
      dialogueScript.EndDialogue();

      // if (talkingCoroutine != null)
      // {
      //   StopCoroutine(talkingCoroutine);
      //   talkingCoroutine = null;
      // }

      charAnimator.SetBool("Talk", false);
    }
  }

  //while detected if we interact start the dialogue
  private void Update()
  {
    if (playerDetected && Input.GetKeyDown(KeyCode.B))
    {
      dialogueScript.StartDialogue();
      charAnimator.SetBool("Talk", true);
      // if (talkingCoroutine == null)
      // {
      //   talkingCoroutine = StartCoroutine(PlayTalkingAnimation());
      // }
    }
  }

  // private IEnumerator PlayTalkingAnimation()
  // {
  //   charAnimator.SetBool("Talk", true);
  //   while (dialogueScript.IsDialogueRunning()) // Kiểm tra hội thoại còn đang chạy
  //   {
  //     yield return null; // Chờ mỗi frame
  //   }
  //   charAnimator.SetBool("Talk", false); // Tắt animation khi hội thoại kết thúc
  //   talkingCoroutine = null; // Reset Coroutine
  // }
}
