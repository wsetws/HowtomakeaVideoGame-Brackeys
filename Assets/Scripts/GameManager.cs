
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool bGameOver = false;
    public GameObject completeLevelUI;
  
    public void GameEnd() {
       
        
        if (bGameOver == false)
         {
            bGameOver = true;
            Debug.Log("Game Over");
            Invoke("RestartLevel",1.3f);
        }

        
    }

    void RestartLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void EndLevel() {

        Debug.Log("Nivel Finalizado");
        completeLevelUI.SetActive(true);
    
    }

}
