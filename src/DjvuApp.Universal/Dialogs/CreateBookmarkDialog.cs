﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using DjvuApp.Dialogs.Internal;

namespace DjvuApp.Dialogs
{
    public static class CreateBookmarkDialog
    {
        public static async Task<string> ShowAsync()
        {
            var dialog = new CreateBookmarkDialogInternal();
            var task = dialog.ShowAsync();
            using (DialogManager.GetForCurrentThread().AddPendingDialog(task))
            {
                try
                {
                    await task;
                }
                catch (OperationCanceledException)
                {
                }
            }
            return dialog.IsSaved ? dialog.BookmarkTitle : null;
        }
    }
}
