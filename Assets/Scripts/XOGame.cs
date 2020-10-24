using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XOGame : MonoBehaviour
{
    // Start is called before the first frame update
	
	public Sprite[] texture;
	public Button[] buttons;
	
	private int[,] board = new int[3, 3];
	private bool cross = true;
	
    void Start()
    {
		for (int i = 0; i < buttons.Length; i++){
				buttons[i].transform.GetComponent<Image>().sprite = texture[2];
				buttons[i].transform.GetComponent<Main>().generate = true;
		}
		
		for (int i = 0; i < 3; i++){
					for (int j = 0; j < 3; j++){
						board[i, j] = 9;
					}
		}
		cross = true;
    }
    // Update is called once per frame
    void Update()
    {
        CheckWinner();
    }
	
	private void CheckWinner(){
		
	}
	
	public void Paint(Button button, string j_i){
		if(button.transform.GetComponent<Main>().generate){
			string[] words = j_i.Split('_');
			board[Convert.ToInt32(words[1]), Convert.ToInt32(words[0])] = Convert.ToInt32(cross);
			
		}
	}
}
