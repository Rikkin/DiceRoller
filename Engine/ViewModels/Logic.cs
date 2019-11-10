using System;
using Engine.Tools;

namespace Engine.ViewModels
{
    public class Logic
    {
        public event EventHandler<BaseMessageEventArgs> OnMessageRaised;

        public void RollDice(int diceSize)
        {
            RaiseMessage($"{RandomNumberGenerator.NumberBetween(1, diceSize)}");
        }

        private void RaiseMessage(string message)
        {
            OnMessageRaised?.Invoke(this, new BaseMessageEventArgs(message));
        }
    }
}
