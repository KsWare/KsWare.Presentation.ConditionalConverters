using System;

namespace KsWare.Presentation.Converters;

public class ConditionalOpacityConverter : ConditionalConverter<double> {

    private static readonly ConditionalOpacityConverter Default = new ConditionalOpacityConverter();
    private static readonly ConditionalOpacityConverter Inverse = new ConditionalOpacityConverter(0.5, 1.0);


    public ConditionalOpacityConverter() {
        True = 1.0;
        False = 0.5;
    }

    public ConditionalOpacityConverter(double trueValue, double falseValue) {
        True = trueValue;
        False = falseValue;
    }

    public override object ProvideValue(IServiceProvider serviceProvider) {
        return True == Default.True && False == Default.False
            ? Default // if default values are used, memory is saved
            : True == Inverse.True && False == Inverse.False
            ? Inverse
            : this; // otherwise it will simply return the current instance
                    // if the same non-default values are used frequently
                    // we could also save the converter in Dictionary.
    }

}