using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._2._Middle._1233._Remove_Sub_Folders_from_the_Filesystem;

public class Solution
{
    private StringBuilder helpStringBuilder = new();

    public IList<string> RemoveSubfolders(string[] folders)
    {
        Array.Sort(folders, (s1, s2) => Math.Sign(s1.Length - s2.Length));

        var rootFolder = new Folder();

        var result = new List<string>();
        foreach (var folder in folders)
        {
            var isCheckedFolder = false;
            var realFolder = rootFolder;
            foreach (var dir in ParsePath(folder))
                isCheckedFolder |= realFolder.TryGetCheckedSubfolder(dir, out realFolder);
            if (!isCheckedFolder)
                result.Add(folder);
            realFolder.IsChecked = true;
        }

        return result;
    }

    private IEnumerable<string> ParsePath(string folder)
    {
        foreach (var c in folder.Skip(1))
            if (c == '/')
            {
                yield return helpStringBuilder.ToString();
                helpStringBuilder.Clear();
            }
            else
                helpStringBuilder.Append(c);

        yield return helpStringBuilder.ToString();
        helpStringBuilder.Clear();
    }

    private class Folder
    {
        public bool IsChecked { get; set; }

        private Dictionary<string, Folder> subfolders;

        public bool TryGetCheckedSubfolder(string subfolderName, out Folder folder)
        {
            if (subfolders == null)
                subfolders = new Dictionary<string, Folder>();

            if (subfolders.TryGetValue(subfolderName, out folder))
                return folder.IsChecked;

            folder = new Folder();
            subfolders[subfolderName] = folder;
            return false;
        }
    }
}