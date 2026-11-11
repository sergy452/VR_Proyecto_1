using UnityEngine;

// Enciende y apaga la linterna. Se conecta al evento Activated
// del XR Grab Interactable (gatillo mientras se sostiene).
public class Linterna : MonoBehaviour
{
    [SerializeField] Light luz;
    [SerializeField] bool encendidaAlInicio = false;

    void Start()
    {
        luz.enabled = encendidaAlInicio;
    }

    public void Alternar()
    {
        luz.enabled = !luz.enabled;
    }
}