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
using Cube.Pdf.App.Editor;
using Cube.Xui.Converters;
using NUnit.Framework;
using System.Globalization;
using System.Windows.Input;

namespace Cube.Pdf.Tests.Editor
{
    /* --------------------------------------------------------------------- */
    ///
    /// SimplexConverterTest
    ///
    /// <summary>
    /// Tests for various converter classes.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    [TestFixture]
    class SimplexConverterTest
    {
        #region Tests

        /* ----------------------------------------------------------------- */
        ///
        /// Convert_WaitCursor
        ///
        /// <summary>
        /// Tests to convert a boolean value to the wait cursor.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Test]
        public void Convert_WaitCursor() => Assert.That(
            Convert<Cursor>(new BooleanToCursor(), true),
            Is.EqualTo(Cursors.Wait)
        );

        /* ----------------------------------------------------------------- */
        ///
        /// Convert_ArrowCursor
        ///
        /// <summary>
        /// Tests to convert a boolean value to the arrow cursor.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Test]
        public void Convert_ArrowCursor() => Assert.That(
            Convert<Cursor>(new BooleanToCursor(), false),
            Is.EqualTo(Cursors.Arrow)
        );

        #endregion

        #region Helper methods

        /* ----------------------------------------------------------------- */
        ///
        /// Convert
        ///
        /// <summary>
        /// Convert メソッドを実行します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private T Convert<T>(SimplexConverter src, object value) =>
            (T)src.Convert(value, typeof(T), null, CultureInfo.CurrentCulture);

        #endregion
    }
}
