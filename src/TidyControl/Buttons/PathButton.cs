using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TidyControl.Buttons
{
    [TemplatePart(Name = "PART_TextBlock", Type = typeof(TextBlock))]
    [TemplatePart(Name = "PART_Path", Type = typeof(System.Windows.Shapes.Path))]
    public class PathButton : BaseButton
    {
        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }
        public static readonly System.Windows.DependencyProperty PathDataProperty =
            System.Windows.DependencyProperty.Register("PathData", typeof(Geometry), typeof(PathButton));





        public SolidColorBrush Fill
        {
            get { return (SolidColorBrush)GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Fill.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register("Fill", typeof(SolidColorBrush), typeof(PathButton), new PropertyMetadata(Brushes.Black));




        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(PathButton), new PropertyMetadata(string.Empty));



        public FlowDirection TextFlowDirection
        {
            get { return (FlowDirection)GetValue(TextFlowDirectionProperty); }
            set { SetValue(TextFlowDirectionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextFlowDirection.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextFlowDirectionProperty =
            DependencyProperty.Register("TextFlowDirection", typeof(FlowDirection), typeof(PathButton), new PropertyMetadata(FlowDirection.LeftToRight));




        public double PathHeight
        {
            get { return (double)GetValue(PathHeightProperty); }
            set { SetValue(PathHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PathHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PathHeightProperty =
            DependencyProperty.Register("PathHeight", typeof(double), typeof(PathButton), new PropertyMetadata(15d));



        public double PathWidth
        {
            get { return (double)GetValue(PathWidthProperty); }
            set { SetValue(PathWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PathWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PathWidthProperty =
            DependencyProperty.Register("PathWidth", typeof(double), typeof(PathButton),new PropertyMetadata(15d));
        public PathButton()
        {

        }
    }
}
