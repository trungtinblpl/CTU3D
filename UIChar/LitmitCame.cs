using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitmitCame : MonoBehaviour
{
    public GameObject Player;
    private void LateUpdate()
    {
        transform.position = new Vector3(Player.transform.position.x,
        100, Player.transform.position.z);
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LitmitCame : MonoBehaviour
// {
//     public GameObject Player;

//     private void LateUpdate()
//     {
//         // Giữ nguyên độ cao của camera bằng vị trí y của người chơi cộng thêm khoảng cách mong muốn
//         float cameraHeightOffset = 5.0f; // Điều chỉnh offset độ cao nếu cần
//         transform.position = new Vector3(
//             Player.transform.position.x,
//             Player.transform.position.y + cameraHeightOffset,
//             Player.transform.position.z
//         );
//     }
// }
