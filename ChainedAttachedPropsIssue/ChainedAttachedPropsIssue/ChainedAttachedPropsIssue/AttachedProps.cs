using Microsoft.UI.Xaml;

namespace ChainedAttachedPropsIssue
{
    public static class AttachedProps
    {

        #region MyElement attached Property
        public static FrameworkElement GetMyElement(DependencyObject obj)
        {
            return (FrameworkElement)obj.GetValue(MyElementProperty);
        }

        public static void SetMyElement(DependencyObject obj, FrameworkElement value)
        {
            obj.SetValue(MyElementProperty, value);
        }

        public static readonly DependencyProperty MyElementProperty =
        DependencyProperty.RegisterAttached
        (
            "MyElement",
            typeof(FrameworkElement),
            typeof(AttachedProps),
            new PropertyMetadata(null)
        );
        #endregion MyElement attached Property


        #region MyString attached Property
        public static string GetMyString(DependencyObject obj)
        {
            return (string)obj.GetValue(MyStringProperty);
        }

        public static void SetMyString(DependencyObject obj, string value)
        {
            obj.SetValue(MyStringProperty, value);
        }

        public static readonly DependencyProperty MyStringProperty =
        DependencyProperty.RegisterAttached
        (
            "MyString",
            typeof(string),
            typeof(AttachedProps),
            new PropertyMetadata(null)
        );
        #endregion MyString attached Property

    }
}
