using System;
using System.Collections.ObjectModel;

namespace Models
{

    public class ContainerModel
    {
        public int ValueType { get; set; }
        public string ImmutableReferenceType { get; set; }
        public ObservableCollection<ItemModel> Items { get; set; }
    }
    public class ItemModel
    {
        public string Name { get; set; }
    }

}
