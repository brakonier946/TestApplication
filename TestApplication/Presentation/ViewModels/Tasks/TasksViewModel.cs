﻿using System.Threading.Tasks;
using MvvmCross.Commands;
using TestApplication.Presentation.ViewModels.Base;

namespace TestApplication.Presentation.ViewModels.Tasks
{
    public class TasksViewModel : BasePageViewModel
    {
        public IMvxAsyncCommand LoadDataCommand { get; }

        public TasksViewModel()
        {
            LoadDataCommand = new MvxAsyncCommand(OnLoadDataAsync);
        }

        public override Task Initialize()
        {
            return LoadDataCommand.ExecuteAsync();
        }

        private Task OnLoadDataAsync()
        {
            return Task.CompletedTask;
        }
    }
}
