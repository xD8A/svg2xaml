using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Svg2Xaml
{
  public static class SvgExtension
  {
    public static readonly DependencyProperty TitleProperty = DependencyProperty.RegisterAttached(
        "Title", typeof(string), typeof(SvgExtension), new PropertyMetadata(null));

    public static void SetTitle(this DependencyObject element, string value)
    {
      element.SetValue(TitleProperty, value);
    }

    public static string GetTitle(this DependencyObject element)
    {
      return (string)element.GetValue(TitleProperty);
    }
  }
}
