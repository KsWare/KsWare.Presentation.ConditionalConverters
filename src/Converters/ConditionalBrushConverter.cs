using System.Windows.Media;

namespace KsWare.Presentation.Converters;

public class ConditionalBrushConverter : ConditionalConverter<Brush> {

	public ConditionalBrushConverter() {
		True = Brushes.Black;
		False = Brushes.Transparent;
	}

	public ConditionalBrushConverter(Brush trueValue) {
		True = trueValue;
		False = Brushes.Transparent;
	}

	public ConditionalBrushConverter(Brush trueValue, Brush falseValue) {
		True = trueValue;
		False = falseValue;
	}

}