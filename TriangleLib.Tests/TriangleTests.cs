using NUnit.Framework;

namespace TriangleLib.Tests
{
	public class TriangleTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Type_1and2and15_ImpossibleReturned()
		{
			// Arrange
			int a = 1;
			int b = 2;
			int c = 15;
			string expected = "Impossible";

			// Act
			string actual = Triangle.Type(a, b, c);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Type_5and7and9_ObtuseReturned()
		{
			// Arrange
			int a = 5;
			int b = 7;
			int c = 9;
			string expected = "Obtuse";

			// Act
			string actual = Triangle.Type(a, b, c);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Type_4and5and3_RightAngledReturned()
		{
			// Arrange
			int a = 4;
			int b = 5;
			int c = 3;
			string expected = "RightAngled";

			// Act
			string actual = Triangle.Type(a, b, c);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Type_8and8and8_AcuteReturned()
		{
			// Arrange
			int a = 8;
			int b = 8;
			int c = 8;
			string expected = "Acute";

			// Act
			string actual = Triangle.Type(a, b, c);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Type_DoubleValues_ObtuseReturned()
		{
			// Arrange
			double a = 5.1;
			double b = 5.2;
			double c = 7.5;
			string expected = "Obtuse";

			// Act
			string actual = Triangle.Type(a, b, c);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Type_ZeroSide_ImpossibleReturned()
		{
			// Arrange
			double a = 2;
			double b = 2;
			double c = 0;
			string expected = "Impossible";

			// Act
			string actual = Triangle.Type(a, b, c);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}