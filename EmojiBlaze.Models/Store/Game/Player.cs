﻿namespace EmojiBlaze.Models.Store.Game
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public bool HasCurrentTurn { get; set; }
        public int Score { get; set; }
    }
}