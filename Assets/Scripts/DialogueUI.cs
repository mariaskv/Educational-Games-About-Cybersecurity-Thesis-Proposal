using UnityEngine;
using TMPro;
using System.Collections;
using System.Threading;
public class DialogueUI : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;

    private TypewriterEffect typewriterEffect;

    // Start is called before the first frame update

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            enabled = false;
        }
    }

    private void Start(){

        button1.SetActive(false);

        typewriterEffect = GetComponent<TypewriterEffect>();
        ShowDialogue(testDialogue);
        // CloseDialogueBox();
    }

    public void ShowDialogue(DialogueObject dialogueObject){

        // dialogueBox.SetActive(true);
        StartCoroutine(routine:StepThroughDialogue(dialogueObject));

    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject){

        for (int i = 0; i < dialogueObject.Dialogue.Length; i++){
            
            string dialogue = dialogueObject.Dialogue[i];
                        
            // yield return typewriterEffect.Run(dialogue, textLabel);
            yield return RunTypingEffect(dialogue);
            yield return new WaitForSeconds((float)0.3);
            textLabel.text = dialogue;
            yield return null;
            // yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        }
        CloseDialogueBox();
    }

    private IEnumerator RunTypingEffect(string dialogue){
        typewriterEffect.Run(dialogue, textLabel);
        Thread.Sleep(800);
        while(typewriterEffect.isRunning){
            yield return null;

            if(Input.GetKeyDown(KeyCode.Space)){
                typewriterEffect.Stop();
            }
        }
    }

    private void CloseDialogueBox(){
        // dialogueBox.SetActive(false);
        textLabel.text = string.Empty;

            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
    
    }

}
