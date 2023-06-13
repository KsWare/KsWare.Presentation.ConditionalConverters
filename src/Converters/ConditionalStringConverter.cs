namespace KsWare.Presentation.Converters;

public class ConditionalStringConverter : ConditionalConverter<string> {

    public ConditionalStringConverter() {
        True = "True";
        False = "False";
    }

    public ConditionalStringConverter(string trueValue, string falseValue) {
        True = trueValue;
        False = falseValue;
    }
}