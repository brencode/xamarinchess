using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinChess
{
    public partial class ChessBoardTemplate : Grid
    {
        public ChessBoardTemplate()
        {
            InitializeComponent();
        }

        public ChessBoardTemplate(object item)
        {
            InitializeComponent();
            BindingContext = item;
        }

    }
}
