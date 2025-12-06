using System;
using UnityEngine;

public class ChunkTrigger : MonoBehaviour
{
    
    private MapController _mapController;
    public GameObject targetMap;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _mapController = FindFirstObjectByType<MapController>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _mapController.currentChunk = targetMap;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (_mapController.currentChunk == targetMap)
            {
                _mapController.currentChunk = null;
            }
        }
    }
}
