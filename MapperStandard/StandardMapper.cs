using Models;
using Riok.Mapperly.Abstractions;
using System;

namespace MapperStandard
{
    [Mapper]
    public partial class StandarMapper
    {
        public partial ContainerModel Map(ContainerDto source);
    }
}
