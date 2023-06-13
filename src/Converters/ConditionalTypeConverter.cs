using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace KsWare.Presentation.Converters;

public class ConditionalTypeConverter : ConditionalConverter<object> {
	
    public ConditionalTypeConverter(object trueValue, object falseValue) {
        True = trueValue;
        False = falseValue;
    }
}