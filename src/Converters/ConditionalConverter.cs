using System;
using System.Collections;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
// using CCC=KsWare.Presentation.ConditionalConverterCondition;
using static KsWare.Presentation.Converters.ConditionalConverterCondition;

namespace KsWare.Presentation.Converters;

public abstract class ConditionalConverter<T> : MarkupExtension, IValueConverter, IMultiValueConverter {

    public T? True { get; set; }
    public T? False { get; set; }
    public ConditionalConverterCondition Condition { get; set; } = None;

    // ConditionalConverter True False, Operator = '>' Value = '12' 
    // Operator
    // Value

    public object? Convert(object value, Type targetType, object parameter, CultureInfo culture) {
        return ToBool(value) ? Convert(True, targetType, culture) : Convert(False, targetType, culture);
    }

    public object? Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
        var result = true;
        // AND - all values must be true
        foreach (var value in values) {
            if (ToBool(value) == false) {
                result = false;
                break;
            }
        }
        return result ? Convert(True, targetType, culture) : Convert(False, targetType, culture);
    }

    private object? Convert(object? value, Type targetType, CultureInfo culture) {
	    return System.Convert.ChangeType(value, targetType, culture);
    }

    private bool ToBool(object? value) {
        if (Condition == None) {
            switch (value) {
                case null: return false;
                case bool b: return b;
                case string s: return string.IsNullOrEmpty(s) == false;
                case ICollection col: return col.Count > 0;
                case double d: return d != 0 && !double.IsNaN(d);
                case float f: return f != 0;
                case byte ui8: return ui8 != 0;
                case short i16: return i16 != 0;
                case int i32: return i32 != 0;
                case long i64: return i64 != 0;
                case decimal dec: return dec != 0;

                //TODO support other types on demand
                default: return (bool)System.Convert.ChangeType(value, typeof(bool));
            }
        }

        switch (Condition) {
            case IsNull: return value == null;
            case IsNotNull: return value != null;
            // case IsEqual: break;
            // case IsNotEqual: break;
            case StringIsNullOrEmpty: return value == null || value as string == string.Empty;
            case StringIsNotNullOrEmpty: return value != null && value as string != string.Empty;
            default: throw new NotImplementedException();
        }
    }

    public override object ProvideValue(IServiceProvider serviceProvider) {
        return this;
    }

    object[] IMultiValueConverter.ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
        throw new NotSupportedException();
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
        throw new NotSupportedException();
    }

}