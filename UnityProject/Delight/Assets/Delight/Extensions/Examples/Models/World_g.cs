// Model generated from "Schema.txt"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class World : ModelObject
    {
        #region Properties

        [SerializeField]
        private int _order;
        public int Order
        {
            get { return _order; }
            set { SetProperty(ref _order, value); }
        }

        [SerializeField]
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public BindableCollection<Level> Levels
        {
            get { return Models.Levels.Get(this); }
        }

        #endregion
    }

    #region Data Provider

    public partial class WorldData : DataProvider<World>
    {
        #region Fields

        public readonly World World1;
        public readonly World World2;
        public readonly World World3;

        #endregion

        #region Constructor

        public WorldData()
        {
            World1 = new World { Id = "World1", Order = 1, Name = "World 1" };
            Add(World1);
            World2 = new World { Id = "World2", Order = 2, Name = "World 2" };
            Add(World2);
            World3 = new World { Id = "World3", Order = 2, Name = "World 2" };
            Add(World3);
        }

        #endregion
    }

    public static partial class Models
    {
        public static WorldData Worlds = new WorldData();
    }

    #endregion
}
