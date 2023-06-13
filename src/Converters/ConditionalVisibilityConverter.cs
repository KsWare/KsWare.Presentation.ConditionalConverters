using System.Windows;

namespace KsWare.Presentation.Converters;

public class ConditionalVisibilityConverter : ConditionalConverter<Visibility> {

    public ConditionalVisibilityConverter() {
        True = Visibility.Visible;
        False = Visibility.Collapsed;
    }

    public ConditionalVisibilityConverter(Visibility trueValue) {
        True = trueValue;
        False = trueValue == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
    }

    public ConditionalVisibilityConverter(Visibility trueValue, Visibility falseValue) {
        True = trueValue;
        False = falseValue;
    }

}