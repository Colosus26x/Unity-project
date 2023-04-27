using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetodaño : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if (tiempoSiguienteDaño <= 0)
            {
                other.GetComponent<CombateJugador>().TomarDaño(5);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
