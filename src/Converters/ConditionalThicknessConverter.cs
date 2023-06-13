using System.Windows;

namespace KsWare.Presentation.Converters;

public class ConditionalThicknessConverter : ConditionalConverter<Thickness> {

    public ConditionalThicknessConverter() {
        True = new Thickness(1);
        False = new Thickness(0);
    }

    public ConditionalThicknessConverter(Thickness trueValue) {
        True = trueValue;
        False = new Thickness(0); ;
    }

    public ConditionalThicknessConverter(Thickness trueValue, Thickness falseValue) {
        True = trueValue;
        False = falseValue;
    }
}