
using UnityEngine;

public class ENDtrigger : MonoBehaviour
{
    public GameManage gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
