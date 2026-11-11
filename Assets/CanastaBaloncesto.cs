using UnityEngine;

public class CanastaBaloncesto : MonoBehaviour
{
    public ParticleSystem confetti;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Encestado");

        //Destroy(other.gameObject);  

        confetti.Play();
    }


}
