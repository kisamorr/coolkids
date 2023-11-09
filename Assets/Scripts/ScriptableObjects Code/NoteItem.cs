using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/NoteItem")]

public class NoteItem : ScriptableObject
{
    public string noteText;
}
