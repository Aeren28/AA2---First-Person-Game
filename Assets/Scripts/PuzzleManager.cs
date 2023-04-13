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
    private int cyanCounter; 
    private int pinkCounter; 
    private int coralCounter; 

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
    public void CyanATM()
    {
        cyanCounter++;

        switch (cyanCounter)
        {
            case 0:
                PuzzlePiece2[0].SetActive(true);
                PuzzlePiece2[1].SetActive(false);
                PuzzlePiece2[2].SetActive(false);
                PuzzlePiece2[3].SetActive(false);
                break;
            case 1:
                PuzzlePiece2[0].SetActive(false);
                PuzzlePiece2[1].SetActive(true);
                PuzzlePiece2[2].SetActive(false);
                PuzzlePiece2[3].SetActive(false);
                break;
            case 2:
                PuzzlePiece2[0].SetActive(false);
                PuzzlePiece2[1].SetActive(false);
                PuzzlePiece2[2].SetActive(true);
                PuzzlePiece2[3].SetActive(false);
                break;
            case 3:
                PuzzlePiece2[0].SetActive(false);
                PuzzlePiece2[1].SetActive(false);
                PuzzlePiece2[2].SetActive(false);
                PuzzlePiece2[3].SetActive(true);
                break;
            case 4:
                PuzzlePiece2[0].SetActive(true);
                PuzzlePiece2[1].SetActive(false);
                PuzzlePiece2[2].SetActive(false);
                PuzzlePiece2[3].SetActive(false);
                cyanCounter = 0;
                break;

            default:
                break;
        }
    }
    public void PinkATM()
    {
        pinkCounter++;

        switch (pinkCounter)
        {
            case 0:
                PuzzlePiece3[0].SetActive(true);
                PuzzlePiece3[1].SetActive(false);
                PuzzlePiece3[2].SetActive(false);
                PuzzlePiece3[3].SetActive(false);
                break;
            case 1:
                PuzzlePiece3[0].SetActive(false);
                PuzzlePiece3[1].SetActive(true);
                PuzzlePiece3[2].SetActive(false);
                PuzzlePiece3[3].SetActive(false);
                break;
            case 2:
                PuzzlePiece3[0].SetActive(false);
                PuzzlePiece3[1].SetActive(false);
                PuzzlePiece3[2].SetActive(true);
                PuzzlePiece3[3].SetActive(false);
                break;
            case 3:
                PuzzlePiece3[0].SetActive(false);
                PuzzlePiece3[1].SetActive(false);
                PuzzlePiece3[2].SetActive(false);
                PuzzlePiece3[3].SetActive(true);
                break;
            case 4:
                PuzzlePiece3[0].SetActive(true);
                PuzzlePiece3[1].SetActive(false);
                PuzzlePiece3[2].SetActive(false);
                PuzzlePiece3[3].SetActive(false);
                pinkCounter = 0;
                break;

            default:
                break;
        }
    }
    public void CoralATM()
    {
        coralCounter++;

        switch (coralCounter)
        {
            case 0:
                PuzzlePiece4[0].SetActive(true);
                PuzzlePiece4[1].SetActive(false);
                PuzzlePiece4[2].SetActive(false);
                PuzzlePiece4[3].SetActive(false);
                break;
            case 1:
                PuzzlePiece4[0].SetActive(false);
                PuzzlePiece4[1].SetActive(true);
                PuzzlePiece4[2].SetActive(false);
                PuzzlePiece4[3].SetActive(false);
                break;
            case 2:
                PuzzlePiece4[0].SetActive(false);
                PuzzlePiece4[1].SetActive(false);
                PuzzlePiece4[2].SetActive(true);
                PuzzlePiece4[3].SetActive(false);
                break;
            case 3:
                PuzzlePiece4[0].SetActive(false);
                PuzzlePiece4[1].SetActive(false);
                PuzzlePiece4[2].SetActive(false);
                PuzzlePiece4[3].SetActive(true);
                break;
            case 4:
                PuzzlePiece4[0].SetActive(true);
                PuzzlePiece4[1].SetActive(false);
                PuzzlePiece4[2].SetActive(false);
                PuzzlePiece4[3].SetActive(false);
                coralCounter = 0;
                break;

            default:
                break;
        }
    }
}
