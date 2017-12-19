using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.Library.Test
{
	[TestClass]
	public class BuilderTest
	{
		[TestMethod]
		public void BuildIntegerSequenceTest()
		{
			//-- Arrange
			var listBuilder = new Builder();

			//-- Act
			var result = listBuilder.BuildIntegerSequence();

			//-- Analyse
			foreach (var item in result)
			{
				Console.WriteLine(item.ToString());
			}

			//-- Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void BuildStringSequenceTest()
		{
			//-- Arrange
			var listBuilder = new Builder();

			//-- Act
			var result = listBuilder.BuildStringSequence();

			//-- Analyse
			foreach (var item in result)
			{
				Console.WriteLine(item.ToString());
			}

			//-- Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void CompareSequenceTest()
		{
			//-- Arrange
			var listBuilder = new Builder();

			//-- Act
			var result = listBuilder.CompareSequences();

			//-- Analyse
			foreach (var item in result)
			{
				Console.WriteLine(item.ToString());
			}

			//-- Assert
			Assert.IsNotNull(result);
		}
	}
}
