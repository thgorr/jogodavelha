using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MinMax
{
    public struct Play
    {
        public int Line, Column;
        public int Score;
    }

    public static bool DoMinMax(BoardController board, Symbol player, out Play bestPlay)
    {
        bool isMin = (player == Symbol.Cross);

        bestPlay.Line = bestPlay.Column = -1;
        bestPlay.Score = (isMin ? 999 : -999);

        Symbol winner = board.GetWinner();
        if (winner != Symbol.None)
        {
            switch (winner)
            {
                case Symbol.Cross:
                    bestPlay.Score = -100;
                    break;
                case Symbol.Circle:
                    bestPlay.Score = 100;
                    break;
            }
            return false;
        }

        bool foundAnyPlay = false;

        for (int l = 0; l < board.BoardSize; l++)
        {
            for (int c = 0; c < board.BoardSize; c++)
            {
                if (board.GetSymbolAt(l, c) != Symbol.None)
                {
                    continue;
                }

                foundAnyPlay = true;

                board.SetSymbolAt(l, c, player);

                DoMinMax(board, player.GetOther(), out var nextPlay);

                if ((isMin && nextPlay.Score < bestPlay.Score) ||
                    (!isMin && nextPlay.Score > bestPlay.Score))
                {
                    if (bestPlay.Score != nextPlay.Score || Random.value < 0.5f)
                    {
                        bestPlay.Score = nextPlay.Score;
                        bestPlay.Line = l;
                        bestPlay.Column = c;
                    }

                }

                board.SetSymbolAt(l, c, Symbol.None);
            }
        }

        if (!foundAnyPlay)
        {
            bestPlay.Score = 0;
        }

        return foundAnyPlay;
    }
}

