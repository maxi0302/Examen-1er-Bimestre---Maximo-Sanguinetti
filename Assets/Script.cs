using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public string patente;
    public int añoFabricacion;
    public float kilometrosRecorridos;
    public int fechavtoVTV;
    public float HC;
    int añoActual = 2025;
    int antiguedadAuto;
    float promedioKilometraje;

    // Start is called before the first frame update
    void Start()
    {
       //Comprobacion de errores
       if (patente == "")
       {
            Debug.Log("ERROR: Patente no ingresada");
            Debug.Log("VTV no aprobada");
            return;
       } 

       if (añoFabricacion < 1900 || añoFabricacion > añoActual)
       {
            Debug.Log("ERROR: Año de fabricacion no valido");
            Debug.Log("VTV no aprobada");
            return;
       }

       if (kilometrosRecorridos < 0)
       {
            Debug.Log("ERROR: La cantidad de kilometros recorridos es menor a 0");
            Debug.Log("VTV no aprobada");
            return;
       }

       if (fechavtoVTV < añoFabricacion || fechavtoVTV > añoActual)
       {
            Debug.Log("ERROR: Fecha de vencimiento de la VTV menor al año de fabricacion o mayor al año actual");
            Debug.Log("VTV no aprobada");
            return;
       }

       if (HC < 5)
       {
            Debug.Log("ERROR: Cantidad de HC menor a 5ppm");
            Debug.Log("VTV no aprobada");
            return;
       }

       //comprobacion si aprueba
       if (HC > 100)
       {
            Debug.Log("VTV no aprobada");
            return;
       }

       //Promedio kilometraje
        antiguedadAuto = añoActual - añoFabricacion;
        promedioKilometraje = kilometrosRecorridos / antiguedadAuto;
            
        if (promedioKilometraje < 10000)
        {
            Debug.Log("VTV otorgada por dos años");
        } else
        {
            Debug.Log("VTV otorgada por un año");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
