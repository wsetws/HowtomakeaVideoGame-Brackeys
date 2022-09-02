using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    /*
     los componentes son clases ya definidas por el engine. 
     Para asociar una variable como "rb" a un objeto de unity tuve que seleccionarlo en la ui de unity. (inspector) debería poder hacerse en el código.

    */
    public float forwardForce = 2000f; // las variables aparacen en el ui de unity en el componente script. 
    public float sidewaysForce = 500f;

    void Start()
    {
        Debug.Log("Hola"); //Simple_test
        //rb.useGravity = false; //ejemplo de uso de objeto y cambio de propiedad
        //rb.AddForce(0,200,500); //ejemplo de uso de objeto y cambio de propiedad con parámetros
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
         * https://answers.unity.com/questions/10993/whats-the-difference-between-update-and-fixedupdat.html < FixedUpdate vs Update
         * tl;dr FiexUpdate se usa cuando se quiere aplicar fisica a los objetos
         */
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }//Hay mejores  de programar movimiento


        if (rb.position.y < -1f) {

            this.enabled = false;
            //Terminar Juego
            FindObjectOfType<GameManager>().GameEnd();
        }
    }


     
}
