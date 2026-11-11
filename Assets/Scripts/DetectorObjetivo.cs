using UnityEngine;

using UnityEngine.Events;



// Trigger que cuenta los objetos con una etiqueta que entran en él

// (una pelota en una canasta, un proyectil en una diana...) y lanza

// un evento con cada acierto y otro al llegar a los aciertos necesarios.

[RequireComponent(typeof(Collider))]

public class DetectorObjetivo : MonoBehaviour

{

    [SerializeField] string etiqueta = "Lanzable";

    [SerializeField] int necesarios = 1;

    [SerializeField] bool soloSiBaja = false;   // Canasta: solo cuenta si el objeto cae desde arriba

    [SerializeField] AudioSource sonido;

    [SerializeField] UnityEvent alAcertar;      // Con cada acierto

    [SerializeField] UnityEvent alCompletar;    // Al llegar a los aciertos necesarios



    int aciertos;



    void OnTriggerEnter(Collider otro)

    {

        if (aciertos >= necesarios || !otro.CompareTag(etiqueta)) return;



        Rigidbody rb = otro.attachedRigidbody;

        if (soloSiBaja && (rb == null || rb.linearVelocity.y >= 0f)) return;



        aciertos++;

        if (sonido != null) sonido.Play();

        alAcertar.Invoke();

        if (aciertos == necesarios) alCompletar.Invoke();

    }

}