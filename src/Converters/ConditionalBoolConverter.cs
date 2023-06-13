namespace KsWare.Presentation.Converters;

public class ConditionalBoolConverter : ConditionalConverter<bool> {

	public ConditionalBoolConverter() {
		True = true;
		False = false;
	}

	public ConditionalBoolConverter(ConditionalConverterCondition condition) {
		True = true;
		False = false;
		Condition = condition;
	}

}