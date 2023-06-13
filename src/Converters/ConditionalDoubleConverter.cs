using System.Windows;

namespace KsWare.Presentation.Converters;

public class ConditionalDoubleConverter : ConditionalConverter<double> {

    public ConditionalDoubleConverter() {
        True = 1;
        False = 0;
    }

    public ConditionalDoubleConverter(double trueValue) {
        True = trueValue;
        False = 0;
    }

    public ConditionalDoubleConverter(double trueValue, double falseValue) {
        True = trueValue;
        False = falseValue;
    }
}