using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
       
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Ouch " + collisionInfo.collider.tag);
            movement.enabled = false;
            //Terminar Juego
            FindObjectOfType<GameManager>().GameEnd();
            

        }
    }


}
