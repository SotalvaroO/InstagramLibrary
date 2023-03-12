﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramLibrary.Base.Components.Atoms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CircularImageAtom : ContentView
    {

        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(
            nameof(ImageSource),
            typeof(string), 
            typeof(CircularImageAtom),
            string.Empty,
            BindingMode.TwoWay
        );

        public string ImageSource
        {
            get=> (string)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public CircularImageAtom()
        {
            InitializeComponent();
        }

        private void ContentView_SizeChanged(object sender, EventArgs e)
        {
            var width = Width;
            var height = Height;

            if (width == 0 || height == 0) return;
            if (width > height)
            {
                mainFrame.WidthRequest = height;
                mainFrame.HorizontalOptions = LayoutOptions.Center;
                mainFrame.CornerRadius = (float)height / 2;
            }
            if (height > width)
            {
                mainFrame.HeightRequest = width;
                mainFrame.VerticalOptions = LayoutOptions.Center;
                mainFrame.CornerRadius =(float)width / 2;

            }
            else
            {
                mainFrame.CornerRadius = (float)width / 2;
            }
        }
    }
}