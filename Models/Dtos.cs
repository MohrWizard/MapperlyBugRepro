using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Models
{

    public class ContainerDto
    {
        public int ValueType { get; set; }
        public string ImmutableReferenceType { get; set; }
        public ObservableCollection<ItemDto> Items { get; set; }
    }
    public class ItemDto
    {
        public string Name { get; set; }
    }

}
