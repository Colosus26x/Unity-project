using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateJugador : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private Barradevida barradevida;

    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;
        barradevida.InicializarBarraDeVida(vida);
    }
    public void TomarDaño(int daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void curar(int curacion)
    {
        if ((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }
        else
        {
            vida += curacion;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
