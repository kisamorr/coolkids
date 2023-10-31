using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public Sprite collectibleSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.imageSlots[GameManager.instance.itemsObtained].sprite = collectibleSprite;
        GameManager.instance.itemsObtained++;
        gameObject.SetActive(false);
    }
}
