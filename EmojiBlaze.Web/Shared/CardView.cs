﻿using EmojiBlaze.Models.Store.Game;
using EmojiBlaze.Models.Store.Game.Actions;
using Microsoft.AspNetCore.Components;

namespace EmojiBlaze.Web.Shared
{
    public partial class CardView
    {
        [Parameter]
        public Card Card { get; set; }

        private string HtmlId => Card.X.ToString() + "_" + Card.Y.ToString();

        public void Flip()
        {
            Dispatcher.Dispatch(new TakeTurnAction(Card));
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            GameState.Subscribe(this);
        }
    }
}
