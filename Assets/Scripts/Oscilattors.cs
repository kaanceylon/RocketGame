using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilattors : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 2f; 

    void Start()
    {
        startingPosition = transform.position;
    }
    void Update()
    {
        if(period <= Mathf.Epsilon) { return; }
        float cycles = Time.time / period; // Kaç döngü yaptık ? bir döngüye bölündüğünde ne kadar zaman geçti?
        const float tau = Mathf.PI * 2; // Dairenin etrafında tam turun değeri.

        float rawSinWave = Mathf.Sin(cycles * tau); // bu geçen zamanı tau ile çarptık. ve -1 ile 1 arası değer aldık.

        // -1'den 1 yerine, 0'dan 1'e gitmek istiyorum.

        movementFactor = (rawSinWave + 1f) / 2f;


        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;


        
    }
}
