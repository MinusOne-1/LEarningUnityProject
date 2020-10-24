using System.Collections;
using System.Convert;
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
						board[i, j] = 0;
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
	
	public void Paint(bool generate_, string j_i){
		if(generate_){
			string[] words = j_i.Split('_');
			board[(int)Convert.ToInt32(words[1])][(int)Convert.ToInt(words[0])] = 0;
		}
	}
}
