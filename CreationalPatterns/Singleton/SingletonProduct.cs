namespace CreationalPatterns.Singleton
{
	public sealed class SingletonProduct
	{
		private static SingletonProduct _instace;
		public int ProductValue = 0;
		private SingletonProduct()
		{

		}
		public static SingletonProduct Instance 
		{ 
			get
			{
				if( _instace == null )
					_instace = new SingletonProduct();
				return _instace;
			}
		}
	} 
}
