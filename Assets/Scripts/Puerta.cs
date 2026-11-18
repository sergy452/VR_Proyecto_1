using UnityEngine;

public class Puerta : MonoBehaviour
{
    [Tooltip("Hacia dónde se desplaza al abrirse, en metros")]
    public Vector3 desplazamiento = new Vector3(0.9f, 0f, 0f);
    public float velocidad = 1f;

    Vector3 cerrada, abierta;
    bool abierta_;

    void Start()
    {
        cerrada = transform.localPosition;
        abierta = cerrada + desplazamiento;
    }

    [ContextMenu("Abrir")]
    public void Abrir() { abierta_ = true; }

    [ContextMenu("Cerrar")]
    public void Cerrar() { abierta_ = false; }

    void Update()
    {
        Vector3 destino = abierta_ ? abierta : cerrada;
        transform.localPosition = Vector3.MoveTowards(
            transform.localPosition, destino, velocidad * Time.deltaTime);
    }
}