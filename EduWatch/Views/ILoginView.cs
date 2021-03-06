﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Pass { get; }
        //string TypeOfUser { get; }

        Presenters.ILoginPresenter Presenter { set; }

        IParentView CreateParentView();
        ITeacherView CreateTeacherView();
        ISignUpView CreateSignUpView();
        IAdminView CreateAdminView();
        void StartApplication();
      
   
    }

}
