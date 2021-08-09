using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinApp.ViewModel.MainPage;
using static Xamarin.Forms.Grid;

namespace XamarinApp.Commands.MainPageCommands
{
    public class CreateGridFromListCommand : BaseCommand<MainPageViewModel>
    {
        public CreateGridFromListCommand(MainPageViewModel viewModel): base(viewModel) { }
        public override void Execute(object parameter)
        {
            List<string> infos = new List<string>();
            infos.AddRange(new string[] { "a", "b", "c", "f", "d", "p" });

            StackLayout stack = viewModel.View.grdList;
            stack.BackgroundColor = Color.Green;
            stack.Children.Clear();

            for (int i = 0; i < infos.Count; i++)
            {
                stack.Children.Add(new Label()
                {
                    Text = infos[i],
                    FontSize = 30,
                    HorizontalTextAlignment = TextAlignment.Center,
                    Margin = 5
                });
            }

            //viewModel.View.grdList.Children.Add(stack);
        }
    }
}
