﻿/// Copyright 2016 Kopano b.v.
/// 
/// This program is free software: you can redistribute it and/or modify
/// it under the terms of the GNU Affero General Public License, version 3,
/// as published by the Free Software Foundation.
/// 
/// This program is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
/// GNU Affero General Public License for more details.
/// 
/// You should have received a copy of the GNU Affero General Public License
/// along with this program.If not, see<http://www.gnu.org/licenses/>.
/// 
/// Consult LICENSE file for details

using Acacia.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acacia.UI
{
    public class FeatureSettings : UserControl
    {
        public SettingsPage Settings
        {
            get;
            internal set;
        }

        private bool _dirty;

        public bool Dirty
        {
            get { return _dirty; }
            protected set
            {
                _dirty = value;
                Settings?.SetFeatureDirty(this, value);
            }
        }

        // Should be abstract, but then the designer fails
        virtual public Feature Feature
        {
            get { throw new NotSupportedException(); }
        }

        virtual public void Apply()
        {

        }
    }
}
