using System;

namespace Game
{
    public class NumberGame
    {
        Random random = new Random();
        private int _maxRounds = 5;
        private int _roundsPlayed = 0;
        int[] roundScores = new int[5];
        private bool _isGameOver = false;
        private int _gameScore = 0;
        private int _winningScore = 100;
        private NumberRange _range; //instance from number range
        private NumberList[] numberlist;
        public GameResult result;


        public NumberGame(int maxRounds, NumberRange range)
        {
            _gameScore = 0;
            numberlist = new NumberList[_maxRounds];
            _maxRounds = maxRounds;
            _range = range;
        }

      
        
        //fills number list, calculates & stores scores in roundScores Array
        public void PlayRound()
        {

            if (!_isGameOver)
            {
                numberlist[_roundsPlayed] = new NumberList(_range);
                CalculateRoundScore();
                _roundsPlayed++;
                if (_roundsPlayed == _maxRounds)
                {
                    if (_gameScore < _winningScore)
                    {
                        result = GameResult.PLAYER_LOST;
                        _isGameOver = true;
                    }
                    else if (_gameScore > _winningScore)
                    {
                        result = GameResult.PLAYER_WON;
                        _isGameOver = true;
                    }
                    else if (_gameScore == _winningScore)
                    {
                        result = GameResult.PLAYER_DRAW;
                        _isGameOver = true;
                    }
                }
                else
                        result = GameResult.GAME_NOT_OVER;
            }
        }

        //Calculate score of current round
        private void CalculateRoundScore()
        {
            for (int i = 0; i < (_range.UpperBound + 1)-_range.LowerBound; i++)
            {
                if (numberlist[_roundsPlayed].NumbersFrequency[i] >= 2)
                {
                    roundScores[_roundsPlayed] += numberlist[_roundsPlayed].NumbersFrequency[i] * 10;
                }
            }
            _gameScore += roundScores[_roundsPlayed];
        }

        //starts new game
        public void StartNewGame()
        {
            _isGameOver = false;
            _roundsPlayed = 0;
            _gameScore = 0;
            
        }

        //Method to print out results of the game
        public string getGameResult()
        {
            string resultOutput = "";
            switch (result)
            {
                case GameResult.PLAYER_WON:
                    resultOutput = "Congrats, you have won the game!";
                    break;
                case GameResult.PLAYER_LOST:
                    resultOutput = "Sorry, you lost!";
                    break;
                case GameResult.PLAYER_DRAW:
                    resultOutput = "Tied, the game is a draw";
                    break;
                case GameResult.GAME_NOT_OVER:
                    resultOutput = "Game not over";
                    break;
            }
            return resultOutput;
        }

        //getter properties
        public int[] RoundScores
        { 
            get { return roundScores; }
        }
        
        public bool IsGameOver
        {
            get { return _isGameOver; }
        }
        public bool MaxRoundsReached
        {
            get { return _roundsPlayed == _maxRounds; }
        }
        

        // getting the round scores of each round
        public int GetCurrentRoundScores()
        {
            return roundScores[_roundsPlayed -1];
        }
        
        

        //printing the numbers for each round 
        public string PrintCurrentNums() {
            string strNums = "";
            for (int i = 0; i < 8; i++)
            {
                strNums =strNums + numberlist[_roundsPlayed - 1].Numbers[i] + " ";
            }
            return strNums;
        }
        //getter method for game score
        public int GameScore
        {
            get { return _gameScore; }
        }

        //makes a new string array, and puts the numberlist into that new array for view result form
        public string[] GetRoundNumbers()
        {
            string[] roundNumArray = new string[_roundsPlayed];
            for (int i=0; i < _roundsPlayed; i++)
            {
                roundNumArray[i] = numberlist[i].GetRoundNumbers();
            }
            return roundNumArray;
        }

        //Creates a new string array, converts the round scores to a string, 
        //then puts the roundscores into that new array to display
        //in the view result form
        public string[] GetAllRoundScores()
        {
            string[] roundScoreArray = new string[_roundsPlayed];
            for (int i = 0; i < _roundsPlayed; i++)
            {
                roundScoreArray[i] = roundScores[i].ToString();
            }
            return roundScoreArray;

        }
    }
}
