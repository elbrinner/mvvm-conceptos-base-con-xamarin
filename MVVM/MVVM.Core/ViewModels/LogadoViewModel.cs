using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Core.ViewModels
{
    public class LogadoViewModel : MvxViewModel
    {

        public LogadoViewModel()
        {
            this.ColorBg = "#3CB371";
            this.ColorText = "#FFFFFF";
        }
        private string colorBg;
        private string colorText;

        public string ColorBg
        {
            get
            {
                return colorBg;
            }
            set
            {
                this.colorBg = value;
                this.RaisePropertyChanged(() => this.ColorBg);
            }
        }

        public string ColorText
        {
            get
            {
                return colorText;
            }
            set
            {
                this.colorText = value;
                this.RaisePropertyChanged(() => this.ColorText);
            }
        }
    }
}
