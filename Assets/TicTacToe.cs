using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{
    private char[] board;
    private int player;
    public Text messageText;
    public Text playerInfo;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;
    public GameObject ball7;
    public GameObject ball8;
    public GameObject ball9;

    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    public GameObject position4;
    public GameObject position5;
    public GameObject position6;
    public GameObject position7;
    public GameObject position8;
    public GameObject position9;

    // Start is called before the first frame update
    void Start()
    {
        board = new char[] { 'o', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        player = 0;
        playerInfo.gameObject.SetActive(true);
        playerInfo.text = "Player 1";
        playerInfo.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to return game status
    // 1 for game is over with result 
    // -1 for game is in progress
    // O for game is over and no result
    private int CheckWin()
    {
        if (board[1] == board[2] && board[2] == board[3])
            return 1;
        else if (board[4] == board[5] && board[5] == board[6])
            return 1;
        else if (board[7] == board[8] && board[8] == board[9])
            return 1;
        else if (board[1] == board[4] && board[4] == board[7])
            return 1;
        else if (board[2] == board[5] && board[5] == board[8])
            return 1;
        else if (board[3] == board[6] && board[6] == board[9])
            return 1;
        else if (board[1] == board[5] && board[5] == board[9])
            return 1;
        else if (board[3] == board[5] && board[5] == board[7])
            return 1;
        else if (board[1] != '1' && board[2] != '2' && board[3] != '3'
                        && board[4] != '4' && board[5] != '5' && board[6] != '6'
                      && board[7] != '7' && board[8] != '8' && board[9] != '9')

            return 0;
        else
            return -1;
    }

    public int GetPlayer()
    {
        return player;
    }

    public void UpdateBoard(string objectName)
    {
        int position =  int.Parse((objectName[objectName.Length - 1]).ToString());
        Debug.Log(objectName);
        Debug.Log(objectName[objectName.Length - 1]);
        Debug.Log("Position updates at: " + position);
        char mark = (player == 1) ? 'X' : 'O';

        if (position == 1 && board[1] == '1')

            board[1] = mark;
        else if (position == 2 && board[2] == '2')

            board[2] = mark;
        else if (position == 3 && board[3] == '3')

            board[3] = mark;
        else if (position == 4 && board[4] == '4')

            board[4] = mark;
        else if (position == 5 && board[5] == '5')

            board[5] = mark;
        else if (position == 6 && board[6] == '6')

            board[6] = mark;
        else if (position == 7 && board[7] == '7')

            board[7] = mark;
        else if (position == 8 && board[8] == '8')

            board[8] = mark;
        else if (position == 9 && board[9] == '9')

            board[9] = mark;
        int result = CheckWin();
        if (result == 1)
        {
            Debug.Log("Some one wins");
            messageText.gameObject.SetActive(true);
            if (player == 0)
                messageText.text = "Congradulation! You win!";
            else
                messageText.text = "Sorry, you lose.";
        }
        else if (result == 0)
        {
            Debug.Log("draws!");
            messageText.gameObject.SetActive(true);
            messageText.text = "DRAW!";
        }
        player = (player % 2 == 0) ? 1 : 0;
        if (player == 0)
        {
            playerInfo.text = "Player 1";
            playerInfo.color = Color.blue;
        }
        else
        {
            playerInfo.text = "Player 2";
            playerInfo.color = Color.red;
        }
    }

    public void ResetProperties()
    {
        board[1] = '1';
        board[2] = '2';
        board[3] = '3';
        board[4] = '4';
        board[5] = '5';
        board[6] = '6';
        board[7] = '7';
        board[8] = '8';
        board[9] = '9';

        player = 0;
        playerInfo.text = "Player 1";
        playerInfo.color = Color.blue;

        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
        ball6.SetActive(false);
        ball7.SetActive(false);
        ball8.SetActive(false);
        ball9.SetActive(false);

        position1.tag = "Interactable";
        position2.tag = "Interactable";
        position3.tag = "Interactable";
        position4.tag = "Interactable";
        position5.tag = "Interactable";
        position6.tag = "Interactable";
        position7.tag = "Interactable";
        position8.tag = "Interactable";
        position9.tag = "Interactable";

    }
}
