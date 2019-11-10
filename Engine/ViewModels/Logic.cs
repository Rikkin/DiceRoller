using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Tools;

namespace Engine.ViewModels
{
    public class Logic : BaseNotificationClass
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
