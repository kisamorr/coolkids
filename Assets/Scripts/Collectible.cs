using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public Sprite collectibleSprite;
    public Note note;
    private int currentSlotPosition;

    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.imageSlots[GameManager.instance.itemsObtained].sprite = collectibleSprite;
        currentSlotPosition = GameManager.instance.itemsObtained;
        print("slot position of this item is " + currentSlotPosition);
        GameManager.instance.itemsObtained++;
        print("current itemsObtained number is " + GameManager.instance.itemsObtained);
        gameObject.SetActive(false);
    }

    public void GiveItem()
    {
        print("giving item");
        GameManager.instance.imageSlots[currentSlotPosition].sprite = null;
    }
}
