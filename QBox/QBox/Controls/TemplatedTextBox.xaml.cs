﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace QBox.Controls
{
    public sealed partial class TemplatedTextBox : UserControl
    {
        public TemplatedTextBox()
        {
            this.InitializeComponent();
            
        }




        public FontFamily FontGlyph
        {
            get { return (FontFamily)GetValue(FontGlyphProperty); }
            set { SetValue(FontGlyphProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FontGlyph.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FontGlyphProperty =
            DependencyProperty.Register("FontGlyph", typeof(FontFamily), typeof(TemplatedTextBox), new PropertyMetadata(null));



        public string Glyph
        {
            get { return (string)GetValue(GlyphProperty); }
            set { SetValue(GlyphProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Glyph.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GlyphProperty =
            DependencyProperty.Register("Glyph", typeof(string), typeof(TemplatedTextBox), new PropertyMetadata(null));











        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TemplatedTextBox), new PropertyMetadata(null));



        public string PlaceHolder
        {
            get { return (string)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceHolder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.Register("PlaceHolder", typeof(string), typeof(TemplatedTextBox), new PropertyMetadata(null));

    }
}
