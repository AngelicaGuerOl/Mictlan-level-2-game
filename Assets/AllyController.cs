using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AllyController : MonoBehaviour
{
    public GameObject turbo; // Turbo shield on NPC
    public GameObject playerTurbo; // Turbo shield on Player
    public PlayerController player;
    public GameObject canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            turbo.SetActive(false);
            playerTurbo.SetActive(true);
            player.moveSpeed *= 2;
            canvas.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
    void Start()
    {
        turbo.SetActive(true);
        playerTurbo.SetActive(false);
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
