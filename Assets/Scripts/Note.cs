using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    //public static Note instance;
    public NoteItem note;

    /*private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }*/

    public void ObtainNote()
    {
        GameManager.instance.noteSlots[GameManager.instance.notesObtained].text = note.noteText;
        GameManager.instance.notesObtained++;
    }

    // PUT THIS IN OTHER SCRIPTS TO TRIGGER OBTAINING A NOTE (thanks kisa):
    // Note.instance.ObtainNote();
}
