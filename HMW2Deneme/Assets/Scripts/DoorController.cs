using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door; // Kapı nesnesi için referans
    public float openSpeed = 5f; // Kapının açılma hızı
    private bool isOpening = false; // Kapının açılıp açılmadığını kontrol etmek için

    void Update()
    {
        if (isOpening)
        {
            // Kapıyı yukarı doğru aç
            door.transform.Translate(Vector3.up * openSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BallPrefab")) // Burada "Player" etiketli nesnelerin kapıyı açmasını sağlıyoruz
        {
            isOpening = true;
        }
    }
}



