﻿using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    public class PlayField
    {
        // The tree values is; "X", "", "O"
        public string[,] field = new string[3, 3];

        /// <summary>
        /// Extracts text data out of the "fields" buttons controls
        /// and puts it into a PlayField Data Type.
        /// Used for checking for a winner aswell as in deciding the AI's movess
        /// </summary>
        /// <param name="con"></param>
        public PlayField(Control.ControlCollection con) //Control.ControlCollection controls String[] Text
        {
            // Places the text from the created array into the playField.
            field[0, 0] = con.Find("buttonField1", false).FirstOrDefault().Text;
            field[0, 1] = con.Find("buttonField2", false).FirstOrDefault().Text;
            field[0, 2] = con.Find("buttonField3", false).FirstOrDefault().Text;
            field[1, 0] = con.Find("buttonField4", false).FirstOrDefault().Text;
            field[1, 1] = con.Find("buttonField5", false).FirstOrDefault().Text;
            field[1, 2] = con.Find("buttonField6", false).FirstOrDefault().Text;
            field[2, 0] = con.Find("buttonField7", false).FirstOrDefault().Text;
            field[2, 1] = con.Find("buttonField8", false).FirstOrDefault().Text;
            field[2, 2] = con.Find("buttonField9", false).FirstOrDefault().Text;
        }
    }
}