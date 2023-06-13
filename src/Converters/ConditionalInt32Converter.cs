using System.Windows;

namespace KsWare.Presentation.Converters;

public class ConditionalInt32Converter : ConditionalConverter<int> {

    public ConditionalInt32Converter() {
        True = 1;
        False = 0;
    }

    public ConditionalInt32Converter(int trueValue) {
        True = trueValue;
        False = 0;
    }

    public ConditionalInt32Converter(int trueValue, int falseValue) {
        True = trueValue;
        False = falseValue;
    }
}