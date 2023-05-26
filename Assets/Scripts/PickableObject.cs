using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public ScripteableObject Object;

    SpriteRenderer sRenderer;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();

        sRenderer.sprite = Object.objectSprite;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        InventoryManager.Instance.AddWeapon(Object);
        Destroy(gameObject);
    }

}