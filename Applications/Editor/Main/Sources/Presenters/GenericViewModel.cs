﻿/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
/* ------------------------------------------------------------------------- */
using Cube.Xui;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;

namespace Cube.Pdf.Editor
{
    /* --------------------------------------------------------------------- */
    ///
    /// GenericViewModel(TModel)
    ///
    /// <summary>
    /// Represents the base class of ViewModels.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public abstract class GenericViewModel<TModel> : Presentable<TModel>
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// GenericViewModel
        ///
        /// <summary>
        /// Initializes a new instance of the GenericViewModel class with
        /// the specified arguments.
        /// </summary>
        ///
        /// <param name="model">Model object.</param>
        /// <param name="aggregator">Messenger object.</param>
        /// <param name="context">Synchronization context.</param>
        ///
        /* ----------------------------------------------------------------- */
        protected GenericViewModel(TModel model, Aggregator aggregator, SynchronizationContext context) :
            base(model, aggregator, context) { }

        #endregion

        #region Methods

        /* ----------------------------------------------------------------- */
        ///
        /// Sync
        ///
        /// <summary>
        /// Executes the specified action as a synchronous method.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected void Sync(Action action) => Track(action, true);

        /* ----------------------------------------------------------------- */
        ///
        /// Dispose
        ///
        /// <summary>
        /// Releases the unmanaged resources used by the object and
        /// optionally releases the managed resources.
        /// </summary>
        ///
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources;
        /// false to release only unmanaged resources.
        /// </param>
        ///
        /* ----------------------------------------------------------------- */
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (!disposing) return;
                foreach (var obj in _elements.Values.OfType<IDisposable>()) obj.Dispose();
                _elements.Clear();
                _commands.Clear();
            }
            finally { base.Dispose(disposing); }
        }

        #region Get

        /* ----------------------------------------------------------------- */
        ///
        /// Get
        ///
        /// <summary>
        /// Gets a ICommand object of the specified property name.
        /// </summary>
        ///
        /// <param name="creator">Function to create an object.</param>
        /// <param name="name">Property name.</param>
        ///
        /// <returns>ICommand object.</returns>
        ///
        /* ----------------------------------------------------------------- */
        protected ICommand Get(Func<ICommand> creator, [CallerMemberName] string name = null) =>
            _commands.GetOrAdd(name, e => creator());

        /* ----------------------------------------------------------------- */
        ///
        /// Get
        ///
        /// <summary>
        /// Gets a BindableElement or its inherited object of the specified
        /// property name.
        /// </summary>
        ///
        /// <param name="creator">Function to create an object.</param>
        /// <param name="name">Property name.</param>
        ///
        /// <returns>BindableElement or its inherited object.</returns>
        ///
        /* ----------------------------------------------------------------- */
        protected T Get<T>(Func<T> creator, [CallerMemberName] string name = null) where T : IElement
        {
            var dest = _elements.GetOrAdd(name, e => creator());
            Debug.Assert(dest is T);
            return (T)dest;
        }

        #endregion

        #endregion

        #region Fields
        private readonly ConcurrentDictionary<string, ICommand> _commands = new ConcurrentDictionary<string, ICommand>();
        private readonly ConcurrentDictionary<string, IElement> _elements = new ConcurrentDictionary<string, IElement>();
        #endregion
    }
}
