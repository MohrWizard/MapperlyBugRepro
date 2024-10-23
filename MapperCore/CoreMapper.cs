using Models;
using Riok.Mapperly.Abstractions;

namespace MapperCore
{

    [Mapper]
    public partial class CoreMapper
    {
        public partial ContainerModel Map(ContainerDto source);
    }

}
