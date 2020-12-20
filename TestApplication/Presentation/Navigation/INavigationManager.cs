﻿using System.Threading.Tasks;
using TestApplication.Core.Presentation.ViewModels.Base;

namespace TestApplication.Core.Presentation.Navigation
{
    public interface INavigationManager
    {
        Task AppStart();

        Task<bool> CloseView(BasePageViewModel viewModel);
    }
}
