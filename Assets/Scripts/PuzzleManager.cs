using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{

    public GameObject[] PuzzlePiece1;
    public GameObject[] PuzzlePiece2;
    public GameObject[] PuzzlePiece3;
    public GameObject[] PuzzlePiece4;

    private int purpleCounter;

    public void PurpleATM()
    {
        purpleCounter++;

        switch (purpleCounter)
        {
            case 0:
                PuzzlePiece1[0].SetActive(true);
                PuzzlePiece1[1].SetActive(false);
                PuzzlePiece1[2].SetActive(false);
                PuzzlePiece1[3].SetActive(false);
                break;
            case 1:
                PuzzlePiece1[0].SetActive(false);
                PuzzlePiece1[1].SetActive(true);
                PuzzlePiece1[2].SetActive(false);
                PuzzlePiece1[3].SetActive(false);
                break;
            case 2:
                PuzzlePiece1[0].SetActive(false);
                PuzzlePiece1[1].SetActive(false);
                PuzzlePiece1[2].SetActive(true);
                PuzzlePiece1[3].SetActive(false);
                break;
            case 3:
                PuzzlePiece1[0].SetActive(false);
                PuzzlePiece1[1].SetActive(false);
                PuzzlePiece1[2].SetActive(false);
                PuzzlePiece1[3].SetActive(true);
                break;
            case 4:
                PuzzlePiece1[0].SetActive(true);
                PuzzlePiece1[1].SetActive(false);
                PuzzlePiece1[2].SetActive(false);
                PuzzlePiece1[3].SetActive(false);
                purpleCounter = 0;
                break;

            default:
                break;
        }
    }
}
