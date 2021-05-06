namespace Models
{
	/// <summary>
	/// Value Object - Entity - Root Aggregate
	/// </summary>
	public class User : object
	{
		// نکته مهم: باید نام تمام پارامترهای ورودی سازنده
		// دقیقا با نام پراپرتی‌ها/فیلدهای کلاس یکسان باشند
		// هر چند که کوچکی و بزرگی نام آنها اهمیتی ندارد
		//[System.Text.Json.Serialization.JsonConstructor]
		//public User(string uname, string password) : base()
		//{
		//	Username = uname;
		//	Password = password;
		//}

		[System.Text.Json.Serialization.JsonConstructor]
		public User(string username, string password) : base()
		{
			Username = username;
			Password = password;
		}

		public string Username { get; }

		public string Password { get; }

		[System.Text.Json.Serialization.JsonIgnore]
		public string Description { get; set; }

		public string GetString()
		{
			string result =
				$"{nameof(Username)}: {Username} - {nameof(Password)}: {Password} - {nameof(Description)}: {Description}";

			return result;
		}
	}
}
