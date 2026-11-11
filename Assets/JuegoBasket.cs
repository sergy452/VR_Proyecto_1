using UnityEngine;

public class JuegoBasket : MonoBehaviour
{

    public GameObject pelotaPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   

    public void crearPelota()
    {
        Instantiate(pelotaPrefab);
    }
}
