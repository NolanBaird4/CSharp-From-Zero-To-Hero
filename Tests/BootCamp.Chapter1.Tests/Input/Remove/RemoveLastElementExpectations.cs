﻿using System.Collections.Generic;

namespace BootCamp1.Chapter.Tests.Input.Remove
{
    public class RemoveLastElementExpectations: RemoveElementExpectations
    {
        protected override IList<object[]> GetSpecificScenarios()
        {
            return new List<object[]>()
            {
                new object[] { Arrays.TwoElementsAsc, new[] { 0 } }
            };
        }
    }
}