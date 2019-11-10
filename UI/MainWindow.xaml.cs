using System.Windows;
using System.Windows.Documents;
using Engine.ViewModels;
using Engine.Tools;

namespace UI
{
    public partial class MainWindow : Window
    {
        private readonly Logic _logic = new Logic();

        public MainWindow()
        {
            InitializeComponent();

            _logic.OnMessageRaised += OnLogicMessagedRaised;
        }

        private void OnClick_D100(object sender, RoutedEventArgs e)
        {
            _logic.RollDice(100);
        }

        private void OnClick_D12(object sender, RoutedEventArgs e)
        {
            _logic.RollDice(12);
        }

        private void OnClick_D10(object sender, RoutedEventArgs e)
        {
            _logic.RollDice(10);
        }

        private void OnClick_D8(object sender, RoutedEventArgs e)
        {
            _logic.RollDice(8);
        }

        private void OnClick_D6(object sender, RoutedEventArgs e)
        {
            _logic.RollDice(6);
        }

        private void OnClick_D4(object sender, RoutedEventArgs e)
        {
            _logic.RollDice(4);
        }

        private void OnClick_D20(object sender, RoutedEventArgs e)
        {
            _logic.RollDice(20);
        }

        private void OnLogicMessagedRaised(object sender, BaseMessageEventArgs e)
        {
            ResultMessages.Document.Blocks.Add(new Paragraph(new Run(e.Message)));
            ResultMessages.ScrollToEnd();
        }
    }
}
