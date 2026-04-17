using UnityEngine;

public class Mover_objetos : MonoBehaviour
{
    public float velocidad = 5f;
    public float amplitud = 5f;
    public bool usarDesfaseAleatorio = false;

    private Vector3 posicionInicial;
    private float desfase;

    void Start()
    {
        posicionInicial = transform.position;
        
        // Esto evita que todos los objetos se muevan como un bloque rígido
        if (usarDesfaseAleatorio) {
            desfase = Random.Range(0f, 2f * Mathf.PI);
        }
    }

    void Update()
    {
        // Añadimos el desfase al cálculo del tiempo
        float movimiento = Mathf.Sin((Time.time * velocidad) + desfase) * amplitud;
        transform.position = posicionInicial + new Vector3(movimiento, 0, 0);
    }
}