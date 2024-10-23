using Models;
using Riok.Mapperly.Abstractions;
using System;

namespace MapperStandard
{
    [Mapper]
    public partial class StandarMapper
    {
        // TODO: Check why it makes source generator explode!
        public partial ContainerModel Map(ContainerDto source);
        public partial ItemModel Map(ItemDto source);
    }
}
