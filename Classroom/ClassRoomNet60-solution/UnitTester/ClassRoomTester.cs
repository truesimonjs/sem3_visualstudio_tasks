using ClassRoomNet60;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTester
{
    public class ClassRoomTester
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(12)]
        //[InlineData(3)]
        public void StudentBornInWinterTest(int month)
        {
            Student student = new("john", month, 10);
            Assert.Equal("Winter", student.Season());
        }

    }
}
