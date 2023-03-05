using UnityEngine;
using TMPro;
using System.Collections;
public class DialogueUI : MonoBehaviour
{
    public GameObject button1;

    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;

    private TypewriterEffect typewriterEffect;

    // Start is called before the first frame update
    private void Start(){

        typewriterEffect = GetComponent<TypewriterEffect>();
        ShowDialogue(testDialogue);
        // CloseDialogueBox();
    }

    public void ShowDialogue(DialogueObject dialogueObject){

        // dialogueBox.SetActive(true);
        StartCoroutine(routine:StepThroughDialogue(dialogueObject));

    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject){

        foreach (string dialogue in dialogueObject.Dialogue){
        
            yield return typewriterEffect.Run(dialogue, textLabel);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        }
        CloseDialogueBox();
    }

    private void CloseDialogueBox(){
        // dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
        button1.SetActive(true);
    }

}
