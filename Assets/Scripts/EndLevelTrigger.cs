using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.EndLevel();

    }
}
