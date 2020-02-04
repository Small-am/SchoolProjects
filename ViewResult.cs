using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game;

namespace PlayGameForm
{
    public partial class ViewResult : Form
    {
        NumberGame _gameResult;
        public ViewResult(NumberGame gameResult)
        {
            InitializeComponent();
            _gameResult = gameResult;

        }

        //When the view form is loaded, displays all the round numbers, scores, and which round
        //and the final total score
        private void ViewResult_Load(object sender, EventArgs e)
        {
            
            //Names for the columns
            DGVNumberList.ColumnCount = 3;
            DGVNumberList.Columns[0].Name = "Round #";
            DGVNumberList.Columns[1].Name = "Round Numbers";
            DGVNumberList.Columns[2].Name = "Round Score";

            //Adds the results on the Data Grid View rows
            for(int i= 0; i< _gameResult.GetRoundNumbers().Length; i++)
            {
                DGVNumberList.Rows.Add(i+1, _gameResult.GetRoundNumbers()[i], _gameResult.GetAllRoundScores()[i]);

            }
            lblGameScore.Text = _gameResult.GameScore.ToString();
            lblResult.Text = _gameResult.getGameResult();
        }
    }
}
