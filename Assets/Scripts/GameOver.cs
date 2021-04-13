using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject text;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        text.SetActive(true);
    }
}
