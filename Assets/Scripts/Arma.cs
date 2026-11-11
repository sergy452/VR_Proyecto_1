using UnityEngine;



// Dispara proyectiles físicos desde la boca del arma.

// Pistola: 1 proyectil sin dispersión. Escopeta: varios perdigones con dispersión.

// Disparar() se conecta al evento Activated del XR Grab Interactable.

public class Arma : MonoBehaviour

{

    [SerializeField] Transform boca;                // Punto de salida, eje Z hacia delante

    [SerializeField] Rigidbody prefabProyectil;

    [SerializeField] float velocidad = 20f;         // Metros por segundo

    [SerializeField] int proyectilesPorDisparo = 1;

    [SerializeField] float dispersion = 0f;         // Grados

    [SerializeField] float cadencia = 0.3f;         // Segundos entre disparos

    [SerializeField] AudioSource sonido;



    float siguienteDisparo;



    public void Disparar()

    {

        if (Time.time < siguienteDisparo) return;

        siguienteDisparo = Time.time + cadencia;



        for (int i = 0; i < proyectilesPorDisparo; i++)

        {

            Quaternion desvio = Quaternion.Euler(Random.Range(-dispersion, dispersion),

                                                 Random.Range(-dispersion, dispersion), 0f);

            Quaternion direccion = boca.rotation * desvio;

            Rigidbody proyectil = Instantiate(prefabProyectil, boca.position, direccion);

            proyectil.linearVelocity = direccion * Vector3.forward * velocidad;

            Destroy(proyectil.gameObject, 5f);

        }



        if (sonido != null) sonido.Play();

    }

}