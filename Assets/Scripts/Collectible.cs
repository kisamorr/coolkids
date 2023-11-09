using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public Sprite collectibleSprite;

    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.imageSlots[GameManager.instance.itemsObtained].sprite = collectibleSprite;
        GameManager.instance.itemsObtained++;
        gameObject.SetActive(false);
    }
}
