using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue_script : MonoBehaviour
{
	//private Animator anim;
   public GameObject dialogueBox;
   public Text dialogueText;
   public bool playerInRange = false;
   public int primeInt = 0;
   public string dialogue0 = "test1";
   public string dialogue1 = "test2";
   public string dialogue2;
   public string dialogue3;
   public string dialogue4;
   public string dialogue5;
   private bool dialogueFinished = false;

   void Start () 
   {
	//anim = gameObject.GetComponentInChildren<Animator>();
	//anim.SetBool("Chat", false);
	dialogueBox.SetActive(false);
   }

   void Update () 
   {
	   	if ((playerInRange) && (dialogueFinished))
	   	{
		   dialogueBox.SetActive(true);
		   if (Input.GetKeyDown(KeyCode.Space)){       //can change the key to an Input Button
		        NPCdialogue();}
		} 
		else 
		{
		       dialogueBox.SetActive(false);
		}
   }

   public void NPCdialogue ()
   {
	  primeInt +=1;

	  if (primeInt == 1){
	         dialogueText.text = dialogue0;
	  }

	  if (primeInt == 2){
	         dialogueText.text = dialogue1;
	  }

	  if (primeInt == 3){
	         dialogueText.text = dialogue2;
	  }

	  if (primeInt ==4){
	         dialogueText.text = dialogue3;
	  }

	  if (primeInt ==5){
	         dialogueText.text = dialogue4;
	  }

	  if (primeInt == 6){
	         dialogueText.text = dialogue5;
	  }

	  if (primeInt == 7){
	         dialogueBox.SetActive(false);
	         dialogueFinished = true;
	         dialogueText.text = "...";
	  }
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
		if (other.gameObject.tag == "Player") {
			playerInRange = true;
			primeInt = 0;
			//anim.SetBool("Chat", true);
			//Debug.Log("Player in range");
		}
   }
                    
   private void OnTriggerExit2D(Collider2D other)
   {
         if (other.gameObject.tag =="Player") {
			playerInRange = false;
			dialogueBox.SetActive(false);
			dialogueFinished = false;
			primeInt = 0;
			//anim.SetBool("Chat", false);
			//Debug.Log("Player left range");
         }
   }

}
