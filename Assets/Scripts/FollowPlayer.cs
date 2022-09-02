using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    /*transform es un componente q contiene la informacion de la poscision y rotacion . 
     * este objeto player va ser asociado al objeto player en unity*/
    public Vector3 CameraOffset;

    void Update()
    {
        //Debug.Log(player.position);
        transform.position = player.position + CameraOffset;
        
    }
}
