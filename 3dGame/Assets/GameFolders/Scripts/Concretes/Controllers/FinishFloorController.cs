using Game.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishFloorController : MonoBehaviour
{
    [SerializeField] GameObject[] _finishedTrails;
    private void Awake()
    {
        foreach (var finishedtrails in _finishedTrails)
        {
            finishedtrails.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = gameObject.GetComponent<PlayerController>();
        if (player == null) return;

        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (var finishedtrails in _finishedTrails)
            {
                Debug.Log("girdi");
                finishedtrails.SetActive(true);
            }

        }
       
    }
}
