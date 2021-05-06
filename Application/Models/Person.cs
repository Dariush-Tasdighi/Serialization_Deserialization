namespace Models
{
	public class Person : object
	{
		public Person(int x, int y, int? z, int? t, int m) : base()
		{
			_x = x;
			Y = y;
			_z = z;
			T = t;
			M = m;
		}

		[System.Text.Json.Serialization.JsonConstructor]
		public Person(int? t, int m) : base()
		{
			T = t;
			M = m;
		}

		/// <summary>
		/// فیلدهای پرایویت سریالایز نمی‌شوند
		/// </summary>
		private int _x;

		public int Y;

		/// <summary>
		/// فیلدهای پرایویت سریالایز نمی‌شوند
		/// </summary>
		private readonly int? _z;

		public readonly int? T;

		public int M { get; }

		public int Width;

		[System.Text.Json.Serialization.JsonInclude]
		public int Height;

		public int Age { get; set; }

		public string FullName { get; set; }

		public string JobPlace { get; set; }

		[System.Text.Json.Serialization.JsonIgnore]
		public string Description { get; set; }

		[System.Text.Json.Serialization.JsonPropertyName("FatherName")]
		public string FName { get; set; }

		public string GetString()
		{
			string result =
				$"{nameof(_x)}: {_x} - {nameof(Y)}: {Y} - {nameof(_z)}: {_z} - {nameof(T)}: {T} - {nameof(M)}: {M} - {nameof(Width)}: {Width} - {nameof(Height)}: {Height} - {nameof(Age)}: {Age} - {nameof(FullName)}: {FullName} - {nameof(FName)}: {FName} - {nameof(Description)}: {Description}";

			return result;
		}
	}
}
