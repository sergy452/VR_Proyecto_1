using System.Collections.Generic;

using UnityEngine;



// Guarda la posición inicial de los objetos y los devuelve a ella con Reiniciar().

// Se conecta, por ejemplo, al evento del botón.

public class ReiniciarObjetos : MonoBehaviour

{

    [SerializeField] Transform[] objetos;



    readonly List<Vector3> posiciones = new List<Vector3>();

    readonly List<Quaternion> rotaciones = new List<Quaternion>();



    void Start()

    {

        foreach (Transform objeto in objetos)

        {

            posiciones.Add(objeto.position);

            rotaciones.Add(objeto.rotation);

        }

    }



    public void Reiniciar()

    {

        for (int i = 0; i < objetos.Length; i++)

        {

            Rigidbody rb = objetos[i].GetComponent<Rigidbody>();

            if (rb != null)

            {

                rb.linearVelocity = Vector3.zero;

                rb.angularVelocity = Vector3.zero;

            }

            objetos[i].SetPositionAndRotation(posiciones[i], rotaciones[i]);

        }

    }

}