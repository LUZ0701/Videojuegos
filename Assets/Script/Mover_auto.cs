using UnityEngine;

public class Mover_auto : MonoBehaviour
{
    [Range(0,20), SerializeField, Tooltip("Velocidad lineal del coche")]

    public float speed = 100f; 

    [Range(0,25), SerializeField, Tooltip("Velocidad de giro del coche")]

    public float turnSpedd = 1000f; 

    public float horizontalInput, VerticalInput; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        this.transform.Translate(speed * Time.deltaTime * Vector3.forward); 
        transform.Rotate(turnSpedd * Time.deltaTime * Vector3.up * horizontalInput);
    }
}
