using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialogueOnCollision : MonoBehaviour
{
    [Header("Day 1 Ink")]
    [SerializeField] private TextAsset day1Json;

    [Header("Day 2 Ink")]
    [SerializeField] private TextAsset day2Json;

    [Header("Day 3 Ink")]
    [SerializeField] private TextAsset day3Json;

    [Header("Day 4 Ink")]
    [SerializeField] private TextAsset day4Json;

    [SerializeField] private Collision2D collision;


    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            handleDialogue();
        }
    }

    private void handleDialogue() {
        int day = MainManager.instance.getDay();

        switch (day) {
            case 1:
                
                 DialogueManager.GetInstance().EnterDialogueMode(day1Json);
                
                break;
            case 2:
                
                DialogueManager.GetInstance().EnterDialogueMode(day2Json);
                
                break;
            case 3:
                
                DialogueManager.GetInstance().EnterDialogueMode(day3Json);
                
                break;
            case 4:
                
                DialogueManager.GetInstance().EnterDialogueMode(day4Json);
                
                break;
            default:
                Debug.LogError("day " + day + " is out of bounds");
                break;
        }
    }
}
