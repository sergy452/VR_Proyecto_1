using UnityEngine;

// Devuelve el objeto a su punto de partida si cae por debajo de una altura.
// Reaparecer() también se puede llamar desde un evento (un botón, un temporizador).
[RequireComponent(typeof(Rigidbody))]
public class Reaparicion : MonoBehaviour
{
    [SerializeField] Transform puntoDeInicio;
    [SerializeField] float alturaMinima = -2f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < alturaMinima) Reaparecer();
    }

    public void Reaparecer()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.SetPositionAndRotation(puntoDeInicio.position, puntoDeInicio.rotation);
    }
}