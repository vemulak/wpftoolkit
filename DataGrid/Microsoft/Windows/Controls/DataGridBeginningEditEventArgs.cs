//---------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All rights reserved.
//
//---------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Microsoft.Windows.Controls
{
    /// <summary>
    ///     Provides information just before a cell enters edit mode.
    /// </summary>
    public class DataGridBeginningEditEventArgs : EventArgs
    {
        /// <summary>
        ///     Instantiates a new instance of this class.
        /// </summary>
        /// <param name="column">The column of the cell that is about to enter edit mode.</param>
        /// <param name="row">The row container of the cell container that is about to enter edit mode.</param>
        /// <param name="editingEventArgs">The event arguments, if any, that led to the cell entering edit mode.</param>
        public DataGridBeginningEditEventArgs(DataGridColumn column, DataGridRow row, RoutedEventArgs editingEventArgs)
        {
            _dataGridColumn = column;
            _dataGridRow = row;
            _editingEventArgs = editingEventArgs;
        }

        /// <summary>
        ///     When true, prevents the cell from entering edit mode.
        /// </summary>
        public bool Cancel
        {
            get { return _cancel; }
            set { _cancel = value; }
        }
        
        /// <summary>
        ///     The column of the cell that is about to enter edit mode.
        /// </summary>
        public DataGridColumn Column
        {
            get { return _dataGridColumn; }
        }

        /// <summary>
        ///     The row container of the cell container that is about to enter edit mode.
        /// </summary>
        public DataGridRow Row
        {
            get { return _dataGridRow; }
        }

        /// <summary>
        ///     Event arguments, if any, that led to the cell entering edit mode.
        /// </summary>
        public RoutedEventArgs EditingEventArgs
        {
            get { return _editingEventArgs; }
        }

        private bool _cancel;
        private DataGridColumn _dataGridColumn;
        private DataGridRow _dataGridRow;
        private RoutedEventArgs _editingEventArgs;
    }
}