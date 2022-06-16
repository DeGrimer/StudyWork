using StudyWork.Web.Infrastructure.Mappers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FactWebTest
{
    public class AutoMapperTests
    {
        [Fact]
        [Trait("Automapper", "Mapper Configuration")]
        public void ItShould()
        {
            //arrange
            var config = MapperRegistration.GetMapperConfiguration();

            //act

            //assert
            config.AssertConfigurationIsValid();
        }

    }
}
