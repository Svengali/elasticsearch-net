using System.Runtime.Serialization;
using Elasticsearch.Net;


namespace Nest
{
	[StringEnum]
	public enum FieldValueFactorModifier
	{
		[EnumMember(Value = "none")]
		None,

		[EnumMember(Value = "log")]
		Log,

		[EnumMember(Value = "log1p")]
		Log1P,

		[EnumMember(Value = "log2p")]
		Log2P,

		[EnumMember(Value = "ln")]
		Ln,

		[EnumMember(Value = "ln1p")]
		Ln1P,

		[EnumMember(Value = "ln2p")]
		Ln2P,

		[EnumMember(Value = "square")]
		Square,

		[EnumMember(Value = "sqrt")]
		SquareRoot,

		[EnumMember(Value = "reciprocal")]
		Reciprocal
	}
}
